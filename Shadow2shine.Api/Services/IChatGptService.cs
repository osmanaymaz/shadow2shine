namespace Shadow2shine.Api.Services;

public interface IChatGptService
{
    Task<string> AskAsync(string prompt);
}
