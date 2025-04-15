using Microsoft.EntityFrameworkCore;
using OpenAI.Chat;
using SmartExpenseTracker.API.Data;
using System.Text;
using System.Text.RegularExpressions;


namespace SmartExpenseTracker.API.Services
{
    public class AIService
    {

        private readonly ApplicationDbContext _context;

        private readonly IConfiguration _configuration;
        public AIService(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;


        }
        public async Task<string> GetResponseFromAI(string prompt)
        {
            var expenses = await _context.Expenses
            .OrderByDescending(e => e.Date)
            //.Take(10)
            .ToListAsync();
            // Use StringBuilder for cleaner formatting
            var dataSummary = new StringBuilder();
            foreach (var expense in expenses)
            {
                dataSummary.AppendLine($"- {expense.Description} ({expense.Category}): ${expense.Amount:F2} on {expense.Date:yyyy-MM-dd}");
            }
            var model = "gpt-4o";
            ChatClient _client = new(model, _configuration["OpenAI:ApiKey"]);
            ChatCompletion response = await _client.CompleteChatAsync($"""
            You are a financial assistant that answers questions based on expense data. Asnwer the questions as if you are directly connected to the database

            Here are the latest expenses:
            {dataSummary}

            User question:
            {prompt}
            """);
            var aiRes = response.Content[0].Text;
            aiRes = Regex.Replace(aiRes, @"#+\s*", "");            // Remove headings
            aiRes = Regex.Replace(aiRes, @"\*\*(.*?)\*\*", "$1");  // Remove **bold**
            aiRes = Regex.Replace(aiRes, @"\*(.*?)\*", "$1");      // Remove *italic*
            aiRes = Regex.Replace(aiRes, @"\[(.*?)\]\(.*?\)", "$1"); // Remove [text](link)
            aiRes = Regex.Replace(aiRes, @"^- ", "• ");            // Convert `-` to bullet points
            return aiRes;
        }
    }
}
