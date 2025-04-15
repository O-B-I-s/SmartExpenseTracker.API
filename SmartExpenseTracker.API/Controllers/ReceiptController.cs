using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/receipt")]
//[Authorize]
public class ReceiptController : ControllerBase
{
    private readonly ReceiptAnalysisService _receiptAnalysisService;

    public ReceiptController(ReceiptAnalysisService receiptAnalysisService)
    {
        _receiptAnalysisService = receiptAnalysisService;
    }

    [HttpPost("upload")]
    public async Task<IActionResult> UploadReceipt(IFormFile file)
    {
        if (file == null || file.Length == 0)
            return BadRequest("No file uploaded.");

        using var stream = file.OpenReadStream();
        var result = await _receiptAnalysisService.AnalyzeReceiptAsync(stream);

        return Ok(new
        {
            Description = result.Description,
            Amount = result.Amount,
            Date = result.Date
        });
    }
}
