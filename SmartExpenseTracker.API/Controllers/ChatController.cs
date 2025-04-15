using Microsoft.AspNetCore.Mvc;
using SmartExpenseTracker.API.Services;

namespace SmartExpenseTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class ChatController : ControllerBase
    {
        private readonly AIService _aiService;

        public ChatController(AIService aiService)
        {
            _aiService = aiService;
        }

        [HttpPost]
        public async Task<IActionResult> AskQuestion([FromBody] ChatRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Question))
                return BadRequest("Question cannot be empty.");

            var response = await _aiService.GetResponseFromAI(request.Question);
            return Ok(new { Answer = response });
        }
    }

    public class ChatRequest
    {
        public string Question { get; set; }
    }
}

