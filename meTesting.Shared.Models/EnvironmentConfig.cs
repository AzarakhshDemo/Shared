namespace meTesting.Shared.Models;

public class EnvironmentConfig
{
    public string AppKey { get; set; }
    public string Url { get; set; }
    public AppDetails Apps { get; set; }
}

public class AppDetails
{
    public string Automation { get; set; }
    public string Bus { get; set; }
    public string Aether { get; set; }
    public string HRM { get; set; }
}