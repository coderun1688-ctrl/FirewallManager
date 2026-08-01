namespace AdvancedFirewallManager;

public class FirewallRuleInfo
{
    public string Name { get; set; } = "";
    public string ApplicationName { get; set; } = "";
    public bool Enabled { get; set; }
    public string Direction { get; set; } = "";
    public string Action { get; set; } = "";
    public string Protocol { get; set; } = "";
    public string LocalPorts { get; set; } = "";
}