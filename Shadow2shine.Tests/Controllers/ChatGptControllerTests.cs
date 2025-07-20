using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shadow2shine.Api.Controllers;
using Shadow2shine.Api.Services;
using Xunit;

public class ChatGptControllerTests
{
    [Fact]
    public async Task Ask_Returns_Echo()
    {
        IChatGptService service = new ChatGptService();
        var controller = new ChatGptController(service);

        var result = await controller.Ask("hello");
        var ok = Assert.IsType<OkObjectResult>(result);
        var value = ok.Value;
        var prop = value?.GetType().GetProperty("response");
        var response = prop?.GetValue(value) as string;
        Assert.Equal("Echo: hello", response);
    }
}
