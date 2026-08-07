using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AdvancedFirewallManager {
	public partial class AddRuleForm:Form {

		public AddRuleForm() {
			InitializeComponent();
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public FirewallService? service {
			get;
			internal set;
		}

		private void AddRuleForm_Load(object sender,EventArgs e) {
						comboBoxProtocol.Items.Add(new ComboboxItem("256","任一"));
						comboBoxProtocol.Items.Add(new ComboboxItem("0","HOPOPT"));
						comboBoxProtocol.Items.Add(new ComboboxItem("1","ICMPv4"));
						comboBoxProtocol.Items.Add(new ComboboxItem("2", "IGMP"));
						comboBoxProtocol.Items.Add(new ComboboxItem("6", "TCP"));
						comboBoxProtocol.Items.Add(new ComboboxItem("17", "UDP"));
						comboBoxProtocol.Items.Add(new ComboboxItem("41","Pv6"));
						comboBoxProtocol.Items.Add(new ComboboxItem("43","IPv6Route"));
						comboBoxProtocol.Items.Add(new ComboboxItem("44","IPv6Frag"));
						comboBoxProtocol.Items.Add(new ComboboxItem("47", "GRE"));
						comboBoxProtocol.Items.Add(new ComboboxItem("58", "ICMPv6"));
						comboBoxProtocol.Items.Add(new ComboboxItem("59", "IPv6NoNxt"));
						comboBoxProtocol.Items.Add(new ComboboxItem("60","IPv6Opts"));
						comboBoxProtocol.Items.Add(new ComboboxItem("112","VRRP"));
						comboBoxProtocol.Items.Add(new ComboboxItem("113","PGM"));
						comboBoxProtocol.Items.Add(new ComboboxItem("115","L2TP"));


						comboBoxProtocol.SelectedIndex = 0;

		}

		private void button_Browse_Click(object sender,EventArgs e) {
			if(openFileDialog1.ShowDialog() == DialogResult.OK) {
				textBox_path.Text = openFileDialog1.FileName;
			}
		}

		private void buttonOK_Click(object sender,EventArgs e) {
			bool checkBoxallowblock = false;
			bool checkBoxInboundOutbound = false;
			int profiles = 0;

			if(string.IsNullOrWhiteSpace(textBoxname.Text) || string.IsNullOrWhiteSpace(textBox_path.Text)) {
				MessageBox.Show("您未輸入名稱及應用程式路徑？","訊息",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				return;
			}

			if(panel3.Controls.OfType<CheckBox>().Count(c => c.Checked) < 1) {
				MessageBox.Show("您未選擇設定檔 ？","訊息",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				return;
			}

			ComboboxItem? item = comboBoxProtocol.Items[comboBoxProtocol.SelectedIndex] as ComboboxItem;

			if((textBoxLocalPorts.Text.Trim().Length > 0 && int.Parse(item.Value) == 256)) {
				MessageBox.Show("您自訂本機埠，協定是不能選擇任一 ？","訊息",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				return;
			} else if(textBoxRemotePorts.Text.Trim().Length > 0 && int.Parse(item.Value) == 256){
				MessageBox.Show("您自訂遠端埠，協定是不能選擇任一 ？","訊息",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				return;
			}


			if(checkBoxDomain.Checked) {
				profiles += 1;
			}
			if(checkBoxPrivate.Checked) {
				profiles += 2;
			}
			if(checkBoxPublic.Checked) {
				profiles += 4;
			}

			if(checkBox_allow.Checked) {
				checkBoxallowblock = true;
			}

			if(checkBox_Inbound.Checked) {
				checkBoxInboundOutbound = true;
			}

			


			//checkBox_allow  checkBox_block
			//checkBox_Inbound checkBox_Outbound
			service.AddApplicationRule(
					textBoxname.Text.Trim(),
					richTextBoxDescription.Text.Trim(),
					textBox_path.Text.Trim(),
					checkBoxallowblock,
					checkBoxInboundOutbound,
					profiles,
					int.Parse(item.Value),
					textBoxLocalAddresses.Text.Trim(),
					textBoxLocalPorts.Text.Trim(),
					textBoxRemoteAddresses.Text.Trim(),
					textBoxRemotePorts.Text.Trim()
			);

			Form1? f = Owner as Form1;
			f.Cursor = Cursors.WaitCursor;
			f.dataGridView1.Rows.Clear();
			f.dataGridView2.Rows.Clear();
			f.backgroundWorker1.RunWorkerAsync();
			this.Close();
		}

		private void allowblock(object sender,EventArgs e) {

			CheckBox current = sender as CheckBox;
			// 如果這個方塊被勾選，就把同群組其他的方塊取消勾選
			if(current.Checked) {
				foreach(Control c in panel1.Controls) {
					if(c is CheckBox cb && cb != current) {
						cb.Checked = false;
					}
				}
			}

		}

		private void Inandout(object sender,EventArgs e) {
			CheckBox current = sender as CheckBox;
			// 如果這個方塊被勾選，就把同群組其他的方塊取消勾選
			if(current.Checked) {
				foreach(Control c in panel2.Controls) {
					if(c is CheckBox cb && cb != current) {
						cb.Checked = false;
					}
				}
			}
		}

		//private readonly FirewallService _service;

		/*
		private readonly TextBox _name = new() { Width = 300 };
		private readonly TextBox _path = new() { Width = 300 };
		private readonly CheckBox _allow = new() { Text = "Allow",Checked = true };
		private readonly CheckBox _inbound = new() { Text = "Inbound",Checked = true };
		*/
		/*
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

			ok.Click += (_,e) =>{
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
			

		}*/


	}
}
