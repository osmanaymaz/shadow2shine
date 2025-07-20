using Shadow2shine.Api.Models;

namespace Shadow2shine.Api.Services;

public interface IGoogleTtsService
{
    Task<string> SynthesizeSpeechAsync(TtsRequest request);
}
