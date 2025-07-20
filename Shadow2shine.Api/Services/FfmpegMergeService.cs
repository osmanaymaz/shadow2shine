using Shadow2shine.Api.Models;

namespace Shadow2shine.Api.Services;

public class FfmpegMergeService : IFfmpegMergeService
{
    public Task<string> MergeAsync(MergeRequest request)
    {
        // placeholder implementation
        var output = request.OutputFile ?? "merged_output.mp3";
        return Task.FromResult(output);
    }
}
