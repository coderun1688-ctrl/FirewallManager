using NetFwTypeLib;

namespace AdvancedFirewallManager;

public class FirewallService{

    private readonly INetFwPolicy2 _policy;

    public FirewallService()  {
        _policy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2")!)!;
    }

    public List<FirewallRuleInfo> GetRules() {

        var list = new List<FirewallRuleInfo>();
		int currentProfiles = _policy.CurrentProfileTypes;
		foreach (INetFwRule rule in _policy.Rules) {

			    //https://www.yuantk.com/weblog/da1953e6-aeed-4f3d-8d6c-ad4a00974431.html
                /*
			    foreach(NET_FW_PROFILE2_TYPE2 profile in Enum.GetValues(typeof(NET_FW_PROFILE2_TYPE2))) {
				    // Skip compound/all values if present in an enum, check individual bits
				    int profileVal = (int)profile;
				    if(profileVal != 0 && (currentProfiles & profileVal) == profileVal) {
					    Console.WriteLine($"Active Profile: {profile}");
				    }
			    }*/

			    list.Add(new FirewallRuleInfo {
                            Name = rule.Name  ,
                            ApplicationName = rule.ApplicationName ?? "",
                            Enabled = rule.Enabled,
                            Direction = rule.Direction == NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN ?  "Inbound"  : "Outbound",
                            Action = rule.Action == NET_FW_ACTION_.NET_FW_ACTION_ALLOW  ?  "Allow"  :  "Block",
                            Protocol = rule.Protocol.ToString(),
                            LocalPorts = rule.LocalPorts ?? ""
                });
        }

        return list.OrderBy(r => r.Name).ToList();

    }

    public void AddApplicationRule(string name, string appPath, bool allow, bool inbound) {

        var rule = (INetFwRule)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule")!)!;

        rule.Name = name;
        rule.ApplicationName = appPath;
        rule.Enabled = true;
        rule.Action = allow
            ? NET_FW_ACTION_.NET_FW_ACTION_ALLOW
            : NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
        rule.Direction = inbound
            ? NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN
            : NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
        rule.Profiles = (int)NET_FW_PROFILE_TYPE2_.NET_FW_PROFILE2_ALL;
        _policy.Rules.Add(rule);

    }

    public void SetRuleEnabled(string name, bool enabled) {
        foreach (INetFwRule rule in _policy.Rules) {
            if (rule.Name.Equals(name, StringComparison.OrdinalIgnoreCase))  {
                rule.Enabled = enabled;
                break;
            }
        }
    }

    public void RemoveRule(string name) {
        _policy.Rules.Remove(name);
    }
}