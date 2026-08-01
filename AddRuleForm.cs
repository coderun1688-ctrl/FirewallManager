using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdvancedFirewallManager {
	public partial class AddRuleForm:Form {
		public AddRuleForm() {
			InitializeComponent();
		}
		private readonly FirewallService _service;

		private readonly TextBox _name = new() { Width = 300 };
		private readonly TextBox _path = new() { Width = 300 };
		private readonly CheckBox _allow = new() { Text = "Allow",Checked = true };
		private readonly CheckBox _inbound = new() { Text = "Inbound",Checked = true };
		public AddRuleForm(FirewallService service) {
			_service = service;

			Text = "Add Firewall Rule";
			Width = 450;
			Height = 220;
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			StartPosition = FormStartPosition.CenterParent;

			var table = new TableLayoutPanel {
				Dock = DockStyle.Fill,
				ColumnCount = 3,
				RowCount = 5,
				Padding = new Padding(10)
			};

			table.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
			table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent,100));
			table.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

			var browse = new Button { Text = "Browse..." };
			browse.Click += (_,_) =>
			{
				using var ofd = new OpenFileDialog {
					Filter = "Executable (*.exe)|*.exe|All files (*.*)|*.*"
				};
				if(ofd.ShowDialog() == DialogResult.OK)
					_path.Text = ofd.FileName;
			};

			var ok = new Button { Text = "OK",DialogResult = DialogResult.OK };
			var cancel = new Button { Text = "Cancel",DialogResult = DialogResult.Cancel };

			table.Controls.Add(new Label { Text = "Rule name:",AutoSize = true },0,0);
			table.Controls.Add(_name,1,0);

			table.Controls.Add(new Label { Text = "Application:",AutoSize = true },0,1);
			table.Controls.Add(_path,1,1);
			table.Controls.Add(browse,2,1);

			table.Controls.Add(_allow,1,2);
			table.Controls.Add(_inbound,1,3);

			var buttons = new FlowLayoutPanel { Dock = DockStyle.Fill };
			buttons.Controls.Add(ok);
			buttons.Controls.Add(cancel);

			table.Controls.Add(buttons,1,4);

			Controls.Add(table);

			AcceptButton = ok;
			CancelButton = cancel;

			ok.Click += (_,e) =>
			{
				if(string.IsNullOrWhiteSpace(_name.Text) ||
					string.IsNullOrWhiteSpace(_path.Text)) {
					MessageBox.Show("Please enter rule name and application path.");
					e = null;
					DialogResult = DialogResult.None;
					return;
				}

				_service.AddApplicationRule(
					_name.Text.Trim(),
					_path.Text.Trim(),
					_allow.Checked,
					_inbound.Checked);
			};
		}

		private void AddRuleForm_Load(object sender,EventArgs e) {

		}
	}
}
