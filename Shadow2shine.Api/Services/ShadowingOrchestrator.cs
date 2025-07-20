namespace Shadow2shine.Api.Services;

public class ShadowingOrchestrator : IShadowingOrchestrator
{
    private readonly IChatGptService _chatGpt;
    private readonly IGoogleTtsService _tts;
    private readonly IFfmpegSegmentService _segment;
    private readonly IFfmpegMergeService _merge;

    public ShadowingOrchestrator(IChatGptService chatGpt, IGoogleTtsService tts, IFfmpegSegmentService segment, IFfmpegMergeService merge)
    {
        _chatGpt = chatGpt;
        _tts = tts;
        _segment = segment;
        _merge = merge;
    }

    // placeholder orchestrator logic
    public async Task<string> RunAsync(string prompt)
    {
        var reply = await _chatGpt.AskAsync(prompt);
        var ttsFile = await _tts.SynthesizeSpeechAsync(new Models.TtsRequest { Text = reply });
        var segmentFile = await _segment.SegmentAsync(new Models.SegmentRequest { InputFile = ttsFile });
        var merged = await _merge.MergeAsync(new Models.MergeRequest { InputFiles = new() { segmentFile }, OutputFile = "final.mp3" });
        return merged;
    }
}
