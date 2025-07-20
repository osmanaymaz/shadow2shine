using Microsoft.AspNetCore.Mvc;
using Shadow2shine.Api.Services;

namespace Shadow2shine.Api.Controllers;

[ApiController]
[Route("chatgpt")]
public class ChatGptController : ControllerBase
{
    private readonly IChatGptService _service;

    public ChatGptController(IChatGptService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> Ask([FromBody] string prompt)
    {
        var response = await _service.AskAsync(prompt);
        return Ok(new { response });
    }
}
