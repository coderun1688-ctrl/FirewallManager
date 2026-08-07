using NetFwTypeLib;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;

namespace AdvancedFirewallManager;

public class FirewallService{

    private readonly INetFwPolicy2 _policy;

	[DllImport("shlwapi.dll",CharSet = CharSet.Unicode,SetLastError = true)]
	private static extern int SHLoadIndirectString(
		string pszSource,
		StringBuilder pszOutBuf,
		uint cchDest,
		IntPtr ppvReserved);

	public FirewallService()  {
        _policy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2")!)!;
    }

	public static string GetLocalizedGroupName(INetFwRule rule) {
		string grouping = rule.Grouping;
		if(string.IsNullOrEmpty(grouping)) {
			return string.Empty;
		}

		// If it starts with '@', it is an indirect string pointing to a resource DLL
		if(grouping.StartsWith("@")) {
					var sb = new StringBuilder(1024);
					int hr = SHLoadIndirectString(grouping,sb,(uint)sb.Capacity,IntPtr.Zero);
					if(hr == 0 /* S_OK */) {
						return sb.ToString();
					}
		}

		// Fallback to the raw grouping string if it is not a resource or resolution fails
		return grouping;
	}

	private static string ProtocolToString(int protocol) {

				return protocol switch {
					0			=>	"HOPOPT",
					1			=>  "ICMPv4",
					2			=>  "IGMP",
					6			=>  "TCP",
					17		=>  "UDP",
					41		 => "Pv6",
					43		=> "IPv6Route" ,
					44		=>  "IPv6Frag",
					47		=>  "GRE",
					58		=>  "ICMPv6",
					59		=>  "IPv6NoNxt",
					60		 => "IPv6Opts",
					112		=>	 "VRRP",
					113		=>	"PGM",
					115		=>  "L2TP",
					256		=>  "任一",
					_ =>	protocol.ToString()
				};
	}
	private static  string ProfilesToString(int profiles) {

		// 全部設定檔
		if(profiles == (int)NET_FW_PROFILE_TYPE2_.NET_FW_PROFILE2_ALL)
			return "域名, 私人, 公開";

		var list = new List<string>();

		if((profiles & (int)NET_FW_PROFILE_TYPE2_.NET_FW_PROFILE2_DOMAIN) != 0)
			list.Add("域名");

		if((profiles & (int)NET_FW_PROFILE_TYPE2_.NET_FW_PROFILE2_PRIVATE) != 0)
			list.Add("私人");

		if((profiles & (int)NET_FW_PROFILE_TYPE2_.NET_FW_PROFILE2_PUBLIC) != 0)
			list.Add("公開");

		return list.Count == 0 ? "無" : string.Join(", ",list);

		/*
		if(profiles == (int)NET_FW_PROFILE_TYPE2_.NET_FW_PROFILE2_ALL)
			return "Domain, Private, Public";

		var list = new List<string>();

		if((profiles & (int)NET_FW_PROFILE_TYPE2_.NET_FW_PROFILE2_DOMAIN) != 0)
			list.Add("Domain");

		if((profiles & (int)NET_FW_PROFILE_TYPE2_.NET_FW_PROFILE2_PRIVATE) != 0)
			list.Add("Private");

		if((profiles & (int)NET_FW_PROFILE_TYPE2_.NET_FW_PROFILE2_PUBLIC) != 0)
			list.Add("Public");

		return list.Count == 0 ? "None" : string.Join(", ",list);
		*/

	}



	public (List<FirewallRuleInfo> Inboundlist ,List<FirewallRuleInfo> Outboundlist) GetRules() {

		var  Inboundlist = new List<FirewallRuleInfo>();
		var  Outboundlist = new List<FirewallRuleInfo>();

		Inboundlist.Clear();
		Outboundlist.Clear();

		CultureInfo culture = new CultureInfo("zh-TW"); // 台湾用 zh-TW (笔画排序)
		StringComparer comparer = StringComparer.Create(culture,false);


		string? ActionName;

		foreach(INetFwRule rule in _policy.Rules) {

			//https://www.yuantk.com/weblog/da1953e6-aeed-4f3d-8d6c-ad4a00974431.html

			//Trace.WriteLine(rule.Profiles);

			ActionName = "";
			if(rule.Action == NET_FW_ACTION_.NET_FW_ACTION_ALLOW) {
				ActionName = "允許";
			} else if(rule.Action == NET_FW_ACTION_.NET_FW_ACTION_BLOCK) {
				ActionName = "封鎖";
			} else if(rule.Action == NET_FW_ACTION_.NET_FW_ACTION_MAX) {
				ActionName = "安全";
			}


			//輸入規則
			if(rule.Direction == NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN){

				            Inboundlist.Add(new FirewallRuleInfo {
                                        Enabled = rule.Enabled,
                                        Name = rule.Name  ,
										Description = rule.Description,
								        Grouping = GetLocalizedGroupName(rule),
										Profiles = ProfilesToString(rule.Profiles),
                                        Action = ActionName,
                                        Protocol = ProtocolToString(rule.Protocol),
										LocalAddresses = rule.LocalAddresses ?? "",
										LocalPorts = rule.LocalPorts ?? "",
										RemoteAddresses = rule.RemoteAddresses ?? "",
										RemotePorts = rule.RemotePorts ?? "",
										ApplicationPath = rule.ApplicationName ?? "",
							});

                //輸出規則
                } else if(rule.Direction == NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT){

				            Outboundlist.Add(new FirewallRuleInfo {
                                        Enabled = rule.Enabled,
                                        Name = rule.Name  ,
										Description = rule.Description,
                                        Grouping =GetLocalizedGroupName(rule),
        								Profiles = ProfilesToString(rule.Profiles),
                                        Action = ActionName,
                                        Protocol =ProtocolToString(rule.Protocol),
										LocalAddresses = rule.LocalAddresses ?? "",
                                        LocalPorts = rule.LocalPorts ?? "",
										RemoteAddresses = rule.RemoteAddresses?? "",
										RemotePorts = rule.RemotePorts?? "",
										ApplicationPath = rule.ApplicationName ?? "",
							});
                }
        }

		return (Inboundlist.OrderBy(x => x.Name,StringComparer.OrdinalIgnoreCase).ToList(),Outboundlist.OrderBy(x => x.Name,StringComparer.OrdinalIgnoreCase).ToList());

	}

    public void AddApplicationRule(string name,string Description, string appPath, bool allow, bool inbound,int profiles,int Protocol,string? LocalAddresses = null,string? LocalPorts = null,string? RemoteAddresses = null,string? RemotePorts = null) {
				//https://blog.csdn.net/somethingGoWay/article/details/131370909

				/*
				var rule = (INetFwRule)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule")!)!;

				rule.Name = name;
				rule.Description = Description ?? "";
				rule.ApplicationName = appPath;
				rule.Profiles = profiles;
				rule.Protocol = Protocol;
				rule.Enabled = true;

				if(!string.IsNullOrEmpty(LocalAddresses)) {
						rule.LocalAddresses = LocalAddresses ??  "*";
				}

				if(!string.IsNullOrEmpty(LocalPorts)) {
						rule.LocalPorts =  LocalPorts.Replace(" ", "");
				}

				if(!string.IsNullOrEmpty(RemoteAddresses)) {
						rule.RemoteAddresses = RemoteAddresses;
				}

				if(!string.IsNullOrEmpty(RemotePorts)) {
						rule.RemotePorts = RemotePorts.Replace(" ","");
				}

				rule.Action = allow ? NET_FW_ACTION_.NET_FW_ACTION_ALLOW : NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
				rule.Direction = inbound ? NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN   : NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
				_policy.Rules.Add(rule);
				*/

				//https://github.com/TechnitiumSoftware/TechnitiumLibrary/blob/master/TechnitiumLibrary.Net.Firewall/WindowsFirewall.cs

				INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
				INetFwRule newRule = (INetFwRule)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
                newRule.Name = name;
				newRule.Description = Description ?? "";
				newRule.Profiles = profiles;
				newRule.Protocol = Protocol;
				newRule.ApplicationName = appPath;
                newRule.Direction = inbound ? NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN   : NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
                newRule.Action = allow ? NET_FW_ACTION_.NET_FW_ACTION_ALLOW : NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
                newRule.Enabled = true;

				if(!string.IsNullOrEmpty(LocalAddresses)) {
						newRule.LocalAddresses = LocalAddresses ??  "*";
				}

				if(!string.IsNullOrEmpty(LocalPorts)) {
						newRule.LocalPorts =  LocalPorts.Replace(" ", "");
				}

				if(!string.IsNullOrEmpty(RemoteAddresses)) {
						newRule.RemoteAddresses = RemoteAddresses;
				}

				if(!string.IsNullOrEmpty(RemotePorts)) {
						newRule.RemotePorts = RemotePorts.Replace(" ","");
				}

				firewallPolicy.Rules.Add(newRule);

	}

	public void EditApplicationRule(string name,string oldname,string Description,string appPath,bool allow,bool inbound,int profiles,int Protocol,string? LocalAddresses = null,string? LocalPorts = null,string? RemoteAddresses = null,string? RemotePorts = null) {

		Type type = Type.GetTypeFromProgID("HNetCfg.FwPolicy2");
		INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(type);

		// Search for the existing rule
		foreach(INetFwRule newRule in firewallPolicy.Rules) {
			if(newRule.Name.Equals(oldname,StringComparison.OrdinalIgnoreCase)) {
						// Edit properties
						newRule.Name = name;
						newRule.Description = Description ?? "";
						newRule.Profiles = profiles;
						newRule.Protocol = Protocol;
						newRule.ApplicationName = appPath;
						newRule.Direction = inbound ? NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN : NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
						newRule.Action = allow ? NET_FW_ACTION_.NET_FW_ACTION_ALLOW : NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
						newRule.Enabled = true;

						if(!string.IsNullOrEmpty(LocalAddresses)) {
							newRule.LocalAddresses = LocalAddresses ?? "*";
						}

						if(!string.IsNullOrEmpty(LocalPorts)) {
							newRule.LocalPorts = LocalPorts.Replace(" ","");
						}

						if(!string.IsNullOrEmpty(RemoteAddresses)) {
							newRule.RemoteAddresses = RemoteAddresses;
						}

						if(!string.IsNullOrEmpty(RemotePorts)) {
							newRule.RemotePorts = RemotePorts.Replace(" ","");
						}
						break;
			}
		}

	}



	public void SetRuleEnabled(string? name, bool enabled) {
        foreach (INetFwRule rule in _policy.Rules) {
            if (rule.Name.Equals(name, StringComparison.OrdinalIgnoreCase))  {
                rule.Enabled = enabled;
                break;
            }
        }
    }

    public void RemoveRule(string? name) {
        _policy.Rules.Remove(name);
    }
}