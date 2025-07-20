using System.Threading.Tasks;
using Shadow2shine.Api.Services;
using Xunit;

public class ShadowingOrchestratorTests
{
    [Fact]
    public async Task RunAsync_Returns_FinalMp3()
    {
        IChatGptService chatGpt = new ChatGptService();
        IGoogleTtsService tts = new GoogleTtsService();
        IFfmpegSegmentService segment = new FfmpegSegmentService();
        IFfmpegMergeService merge = new FfmpegMergeService();

        IShadowingOrchestrator orchestrator = new ShadowingOrchestrator(chatGpt, tts, segment, merge);

        var result = await orchestrator.RunAsync("test");

        Assert.Equal("final.mp3", result);
    }
}
