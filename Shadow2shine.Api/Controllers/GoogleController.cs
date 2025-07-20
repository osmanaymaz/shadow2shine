using Microsoft.AspNetCore.Mvc;
using Shadow2shine.Api.Models;
using Shadow2shine.Api.Services;

namespace Shadow2shine.Api.Controllers;

[ApiController]
[Route("google")]
public class GoogleController : ControllerBase
{
    private readonly IGoogleTtsService _ttsService;

    public GoogleController(IGoogleTtsService ttsService)
    {
        _ttsService = ttsService;
    }

    [HttpPost("tts")]
    public async Task<IActionResult> Tts([FromBody] TtsRequest request)
    {
        var file = await _ttsService.SynthesizeSpeechAsync(request);
        return Ok(new { file });
    }
}
