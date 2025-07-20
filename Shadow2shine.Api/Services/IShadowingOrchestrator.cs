namespace Shadow2shine.Api.Services;

public interface IShadowingOrchestrator
{
    Task<string> RunAsync(string prompt);
}
