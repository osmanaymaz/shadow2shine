using Shadow2shine.Api.Models;

namespace Shadow2shine.Api.Services;

public class GoogleTtsService : IGoogleTtsService
{
    public Task<string> SynthesizeSpeechAsync(TtsRequest request)
    {
        // placeholder implementation
        var output = $"tts_{request.Text.Replace(' ', '_')}.mp3";
        return Task.FromResult(output);
    }
}
