using Azure;
using Azure.AI.DocumentIntelligence;
using SmartExpenseTracker.API.Models;
using SmartExpenseTracker.API.Repositories;
using SmartExpenseTracker.API.Services;
using System.Globalization;
using System.Text.RegularExpressions;

public class ReceiptAnalysisService
{
    private readonly DocumentIntelligenceClient _client;
    private readonly IExpenseRepository _repository;
    private readonly ExpenseCategorizationService _categorizationService;

    public ReceiptAnalysisService(IConfiguration configuration,
        IExpenseRepository repository, ExpenseCategorizationService categorizationService)
    {
        _repository = repository;
        _categorizationService = categorizationService;
        var endpoint = configuration["DocumentIntelligence:Endpoint"];
        var apiKey = configuration["DocumentIntelligence:ApiKey"];
        _client = new DocumentIntelligenceClient(new Uri(endpoint), new AzureKeyCredential(apiKey));
    }

    public async Task<Expense> AnalyzeReceiptAsync(Stream receiptStream)
    {
        var binaryData = BinaryData.FromStream(receiptStream);
        var operation = await _client.AnalyzeDocumentAsync(WaitUntil.Completed, "prebuilt-receipt", binaryData);

        var document = operation.Value.Documents.FirstOrDefault();
        var fields = document?.Fields;
        double totalAmount = 0.00;
        if (fields != null && fields.TryGetValue("Total", out var totalField))
        {
            // Check for currency value first
            if (totalField.FieldType == DocumentFieldType.Currency)
            {
                totalAmount = totalField.ValueCurrency.Amount;
            }
            // Fallback to string parsing
            else if (totalField.Content != null)
            {
                // Clean currency symbols and thousand separators
                var cleanedAmount = Regex.Replace(totalField.Content, @"[^\d.,]", "");
                cleanedAmount = cleanedAmount.Replace(",", "");

                if (double.TryParse(cleanedAmount,
                    NumberStyles.Any,
                    CultureInfo.InvariantCulture,
                    out var parsedAmount))
                {
                    totalAmount = parsedAmount;
                }
            }
        }

        // Extract merchant name with fallback
        var merchantName = fields?.GetValueOrDefault("MerchantName")?.Content ?? "Unknown Merchant";
        var receiptType = fields?.GetValueOrDefault("ReceiptType")?.Content ?? "Receipt";

        var expense = new Expense
        {
            Description = $"{merchantName} - {receiptType}",
            // document?.Fields["MerchantName"]?.Content ?? "Unknown",
            Amount = totalAmount,
            //double.TryParse(document?.Fields["Total"]?.Content, out var amount) ? amount : 0.00,
            Date = DateTime.TryParse(fields?.GetValueOrDefault("TransactionDate")?.Content,
                out var date) ? date : DateTime.UtcNow
            //DateTime.TryParse(document?.Fields["TransactionDate"]?.Content, out var date) ? date : DateTime.UtcNow
        };
        var predictedCategories = _categorizationService.PredictCategories(expense.Description);
        if (expense.Category == null)
        {
            expense.Category = predictedCategories;
        }
        await _repository.AddAsync(expense);
        return expense;
    }
}
