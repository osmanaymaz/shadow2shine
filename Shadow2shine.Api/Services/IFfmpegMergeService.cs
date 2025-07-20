using Shadow2shine.Api.Models;

namespace Shadow2shine.Api.Services;

public interface IFfmpegMergeService
{
    Task<string> MergeAsync(MergeRequest request);
}
