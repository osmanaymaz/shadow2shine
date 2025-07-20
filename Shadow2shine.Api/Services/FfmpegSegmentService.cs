using Shadow2shine.Api.Models;

namespace Shadow2shine.Api.Services;

public class FfmpegSegmentService : IFfmpegSegmentService
{
    public Task<string> SegmentAsync(SegmentRequest request)
    {
        // placeholder implementation
        var output = $"segment_{request.InputFile}";
        return Task.FromResult(output);
    }
}
