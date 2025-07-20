using Microsoft.AspNetCore.Mvc;
using Shadow2shine.Api.Models;
using Shadow2shine.Api.Services;

namespace Shadow2shine.Api.Controllers;

[ApiController]
[Route("ffmpeg")]
public class FfmpegController : ControllerBase
{
    private readonly IFfmpegSegmentService _segmentService;
    private readonly IFfmpegMergeService _mergeService;

    public FfmpegController(IFfmpegSegmentService segmentService, IFfmpegMergeService mergeService)
    {
        _segmentService = segmentService;
        _mergeService = mergeService;
    }

    [HttpPost("segment")]
    public async Task<IActionResult> Segment([FromBody] SegmentRequest request)
    {
        var file = await _segmentService.SegmentAsync(request);
        return Ok(new { file });
    }

    [HttpPost("merge")]
    public async Task<IActionResult> Merge([FromBody] MergeRequest request)
    {
        var file = await _mergeService.MergeAsync(request);
        return Ok(new { file });
    }
}
