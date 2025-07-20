namespace Shadow2shine.Api.Models;

public class SegmentRequest
{
    public string InputFile { get; set; } = string.Empty;
    public TimeSpan Start { get; set; }
    public TimeSpan Duration { get; set; }
}
