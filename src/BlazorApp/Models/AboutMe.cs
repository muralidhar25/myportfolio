namespace BlazorApp.Models;

public class AboutMe
{
    public string Description { get; set; } = string.Empty;
    public List<string> Skills { get; set; } = new();
    public List<string> DetailOrQuote { get; set; } = new();
}