namespace Shadow2shine.Api.Models;

public class MergeRequest
{
    public List<string> InputFiles { get; set; } = new();
    public string? OutputFile { get; set; }
}
