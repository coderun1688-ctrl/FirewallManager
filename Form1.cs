using System.Text.Json;

namespace AdvancedFirewallManager;

public partial class Form1:Form {

	public Form1() {
		InitializeComponent();
	}

	private readonly FirewallService _service = new();
	private List<FirewallRuleInfo> _rules = [];

	private void Form1_Load(object sender,EventArgs e) {
		Shown += async (_,_) => await LoadRulesAsync();
	}

	private async Task LoadRulesAsync() {

		Cursor = Cursors.WaitCursor;
		try {
					_rules = await Task.Run(() => _service.GetRules());
					ApplyFilter();
		} finally {
					Cursor = Cursors.Default;
		}
	}

	private void ApplyFilter() {

		var q = _searchBox.Text.Trim();
		var data = string.IsNullOrWhiteSpace(q)
			? _rules
			: _rules.Where(r => r.Name.Contains(q,StringComparison.OrdinalIgnoreCase) || r.ApplicationName.Contains(q,StringComparison.OrdinalIgnoreCase)).ToList();
		_grid.DataSource = data;
	}

	private FirewallRuleInfo? Selected() => _grid.CurrentRow?.DataBoundItem as FirewallRuleInfo;

	private void SetSelected(bool enabled) {
		var rule = Selected();
		if(rule == null)
			return;

		_service.SetRuleEnabled(rule.Name,enabled);
		_ = LoadRulesAsync();
	}

	private void DeleteSelected() {
		var rule = Selected();
		if(rule == null)
			return;

		if(MessageBox.Show($"Delete rule '{rule.Name}'?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) {
			_service.RemoveRule(rule.Name);
			_ = LoadRulesAsync();
		}
	}

	private void AddRule() {
		using var dlg = new AddRuleForm(_service);
		if(dlg.ShowDialog(this) == DialogResult.OK) {
			_ = LoadRulesAsync();
		}
	}

	private void ExportJson() {
		using var sfd = new SaveFileDialog {
			Filter = "JSON files (*.json)|*.json",
			FileName = "firewall-rules.json"
		};

		if(sfd.ShowDialog() == DialogResult.OK) {
			var json = JsonSerializer.Serialize(_rules,
				new JsonSerializerOptions { WriteIndented = true });

			File.WriteAllText(sfd.FileName,json);
			MessageBox.Show("Export completed.");
		}
	}

	private void _searchBox_TextChanged(object sender,EventArgs e) {
		ApplyFilter();
	}
}
