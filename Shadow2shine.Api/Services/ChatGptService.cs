namespace Shadow2shine.Api.Services;

public class ChatGptService : IChatGptService
{
    public Task<string> AskAsync(string prompt)
    {
        // placeholder implementation
        return Task.FromResult($"Echo: {prompt}");
    }
}
