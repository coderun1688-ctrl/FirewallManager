using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AdvancedFirewallManager {
	public partial class EditRuleForm:Form {

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public FirewallService? service {
			get;
			internal set;
		}


		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string? Names {
			get;
			internal set;
		}
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string? Description {
			get;
			internal set;
		}
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string? Profiles {
			get;
			internal set;
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string? Action {
			get;
			internal set;
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string? Protocol {
			get;
			internal set;
		}
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public int InboundOutbound {
			get;
			internal set;
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string? Apppath {
			get;
			internal set;
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string? LocalAddresses {
			get;
			internal set;
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string? LocalPorts {
			get;
			internal set;
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string? RemoteAddresses {
			get;
			internal set;
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string? RemotePorts {
			get;
			internal set;
		}

		public EditRuleForm() {
			InitializeComponent();
		}

		private void EditRuleForm_Load(object sender,EventArgs e) {
						textBoxname.Text = Names;
						labeloldname.Text = Names;
						richTextBoxDescription.Text = Description;


						comboBoxProtocol.Items.Add(new ComboboxItem("256","任一"));
						comboBoxProtocol.Items.Add(new ComboboxItem("0","HOPOPT"));
						comboBoxProtocol.Items.Add(new ComboboxItem("1","ICMPv4"));
						comboBoxProtocol.Items.Add(new ComboboxItem("2","IGMP"));
						comboBoxProtocol.Items.Add(new ComboboxItem("6","TCP"));
						comboBoxProtocol.Items.Add(new ComboboxItem("17","UDP"));
						comboBoxProtocol.Items.Add(new ComboboxItem("41","Pv6"));
						comboBoxProtocol.Items.Add(new ComboboxItem("43","IPv6Route"));
						comboBoxProtocol.Items.Add(new ComboboxItem("44","IPv6Frag"));
						comboBoxProtocol.Items.Add(new ComboboxItem("47","GRE"));
						comboBoxProtocol.Items.Add(new ComboboxItem("58","ICMPv6"));
						comboBoxProtocol.Items.Add(new ComboboxItem("59","IPv6NoNxt"));
						comboBoxProtocol.Items.Add(new ComboboxItem("60","IPv6Opts"));
						comboBoxProtocol.Items.Add(new ComboboxItem("112","VRRP"));
						comboBoxProtocol.Items.Add(new ComboboxItem("113","PGM"));
						comboBoxProtocol.Items.Add(new ComboboxItem("115","L2TP"));

						//Trace.WriteLine(Protocol);

						var matchItem = comboBoxProtocol.Items.Cast<ComboboxItem>().FirstOrDefault(x => x.Text == Protocol);
						if(matchItem != null) {
								comboBoxProtocol.SelectedItem = matchItem; // 成功找到並選取
						}

						if(Action == "允許") {
									checkBox_allow.Checked = true;
						} else {
									checkBox_block.Checked = true;
						}

						if(InboundOutbound == 0) {
									checkBox_Inbound.Checked = true;
						} else {
									checkBox_Outbound.Checked = true;
						}

						textBox_path.Text = Apppath;

						if(Profiles.Contains("域名") && Profiles.Contains("私人") &&  Profiles.Contains("公開")){
										checkBoxDomain.Checked = true;
										checkBoxPrivate.Checked = true;
										checkBoxPublic.Checked = true;
						} else if(Profiles.Contains("域名")) {
										checkBoxDomain.Checked = true;
						} else if(Profiles.Contains("私人")) {
										checkBoxPrivate.Checked = true;
						} else if(Profiles.Contains("公開")) {
										checkBoxPublic.Checked = true;
						}

						textBoxLocalAddresses.Text = LocalAddresses.Replace("*","");
						textBoxLocalPorts.Text = LocalPorts.Replace("*","");
						textBoxRemoteAddresses.Text = RemoteAddresses.Replace("*","");
						textBoxRemotePorts.Text = RemotePorts.Replace("*","");
		
		}

		private void button_Browse_Click(object sender,EventArgs e) {
			if(openFileDialog1.ShowDialog() == DialogResult.OK) {
				textBox_path.Text = openFileDialog1.FileName;
			}
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

					service.EditApplicationRule(
							textBoxname.Text.Trim(),
							labeloldname.Text.Trim(),
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
	}
}
