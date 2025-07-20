using Shadow2shine.Api.Models;

namespace Shadow2shine.Api.Services;

public interface IFfmpegSegmentService
{
    Task<string> SegmentAsync(SegmentRequest request);
}
