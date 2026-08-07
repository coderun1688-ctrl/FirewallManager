using System.Data;
using System.Diagnostics;
using System.Text;
using System.Text.Json;
using System.Xml.Linq;

namespace AdvancedFirewallManager;

public partial class Form1:Form {

	public Form1() {
		InitializeComponent();
	}
	protected override CreateParams CreateParams {
		get {
			CreateParams cp = base.CreateParams;
			cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED (開啟全視窗雙緩衝)
			return cp;
		}
	}
	private readonly FirewallService _service = new();
	private List<FirewallRuleInfo> rulesInboundlist = [];
	private List<FirewallRuleInfo> rulesOutboundlist = [];

	private void Form1_Load(object sender,EventArgs e) {
		if(backgroundWorker1.IsBusy == false) {
			Cursor = Cursors.WaitCursor;
			backgroundWorker1.RunWorkerAsync();
		}
	}

	private void backgroundWorker1_DoWork(object sender,System.ComponentModel.DoWorkEventArgs e) {

		var (Inboundlist,Outboundlist) = _service.GetRules();

		rulesInboundlist = Inboundlist;
		rulesOutboundlist = Outboundlist;

		this.Invoke(new Action(() => {

			foreach(FirewallRuleInfo Inboundrule in Inboundlist) {

				dataGridView1.Rows.Add(
							Inboundrule.Enabled,
							Inboundrule.Name,
							Inboundrule.Description,
							Inboundrule.Grouping,
							Inboundrule.Profiles,
							Inboundrule.Action,
							Inboundrule.Protocol,
							Inboundrule.LocalAddresses,
							Inboundrule.LocalPorts,
							Inboundrule.RemoteAddresses,
							Inboundrule.RemotePorts,
							Inboundrule.ApplicationPath
				);

			}

			foreach(FirewallRuleInfo Outboundrule in Outboundlist) {

				dataGridView2.Rows.Add(
							Outboundrule.Enabled,
							Outboundrule.Name,
							Outboundrule.Description,
							Outboundrule.Grouping,
							Outboundrule.Profiles,
							Outboundrule.Action,
							Outboundrule.Protocol,
							Outboundrule.LocalAddresses,
							Outboundrule.LocalPorts,
							Outboundrule.RemoteAddresses,
							Outboundrule.RemotePorts,
							Outboundrule.ApplicationPath
				);

			}
		}));
	}

	private void backgroundWorker1_RunWorkerCompleted(object sender,System.ComponentModel.RunWorkerCompletedEventArgs e) {
		backgroundWorker1.CancelAsync();
		backgroundWorker1.Dispose();
		Cursor = Cursors.Default;
	}


	private async void _searchBox_KeyUp(object sender,KeyEventArgs e) {

		if(e.KeyCode == Keys.Back || e.KeyCode == Keys.Space || (e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z) || (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)) {
			
			dataGridView1.Rows.Clear();
			dataGridView2.Rows.Clear();

			if(_searchBox.Text.Trim().Length > 0) {

					await Task.Run(() => {
							this.Invoke(new Action(() => {
										rulesInboundlist.Where(x => x.Name.Contains(_searchBox.Text.Trim(),StringComparison.OrdinalIgnoreCase)).ToList().ForEach(x => {
														dataGridView1.Rows.Add(
																	x.Enabled,
																	x.Name,
																	x.Description,
																	x.Grouping,
																	x.Profiles,
																	x.Action,
																	x.Protocol,
																	x.LocalAddresses,
																	x.LocalPorts,
																	x.RemoteAddresses,
																	x.RemotePorts,
																	x.ApplicationPath
														);
											});

											rulesOutboundlist.Where(x => x.Name.Contains(_searchBox.Text.Trim(),StringComparison.OrdinalIgnoreCase)).ToList().ForEach(x => {
														dataGridView2.Rows.Add(
																	x.Enabled,
																	x.Name,
																	x.Description,
																	x.Grouping,
																	x.Profiles,
																	x.Action,
																	x.Protocol,
																	x.LocalAddresses,
																	x.LocalPorts,
																	x.RemoteAddresses,
																	x.RemotePorts,
																	x.ApplicationPath
														);
											});
							}));
					});

			}  else {

						if(backgroundWorker1.IsBusy == false) {
									backgroundWorker1.RunWorkerAsync();
						}
			}
		}

	}

	private void buttonAddRule_Click(object sender,EventArgs e) {
		AddRuleForm dlg = new AddRuleForm();
		dlg.Owner = this;
		dlg.service = _service;
		dlg.ShowDialog(this);
	}

	private void buttonDelete_Click(object sender,EventArgs e) {

		//FirewallService.RemoveRule();

		string? SelectedName = "";

		if(tabControl1.SelectedIndex == 0) {

			foreach(DataGridViewRow? row in dataGridView1.SelectedRows) {
				string? name = row?.Cells[1].Value?.ToString();
				//Trace.WriteLine(name);
				SelectedName += name + "\n";
			}

			if(MessageBox.Show($"將刪除連入\n{SelectedName}以下規則","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) {
				foreach(DataGridViewRow? row in dataGridView1.SelectedRows.OfType<DataGridViewRow>().ToArray()) {
					dataGridView1.Rows.Remove(row);
					string? name = row?.Cells[1].Value?.ToString();
					_service.RemoveRule(name);
					//Trace.WriteLine(name);
				}
			}

		} else {

			foreach(DataGridViewRow row in dataGridView2.SelectedRows) {
				string? name = row.Cells[1].Value?.ToString();
				//Trace.WriteLine(name);
				SelectedName += name + "\n";
			}

			if(MessageBox.Show($"將刪除連出\n{SelectedName}以下規則","訊息",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) {

				foreach(DataGridViewRow row in dataGridView2.SelectedRows.OfType<DataGridViewRow>().ToArray()) {
					dataGridView2.Rows.Remove(row);
					string? name = row.Cells[1].Value?.ToString();
					_service.RemoveRule(name);
					//Trace.WriteLine(name);

				}
			}
		}


	}

	private void buttonRefresh_Click(object sender,EventArgs e) {
		if(backgroundWorker1.IsBusy == false) {
			Cursor = Cursors.WaitCursor;
			dataGridView1.Rows.Clear();
			dataGridView2.Rows.Clear();
			backgroundWorker1.RunWorkerAsync();
		}
	}


	private void dataGridView1_CellContentClick(object sender,DataGridViewCellEventArgs e) {

		//Enabled1

		if(tabControl1.SelectedIndex == 0) {

			dataGridView1.EndEdit();
			//Trace.WriteLine(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
			_service.SetRuleEnabled(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(),(bool)dataGridView1.Rows[e.RowIndex].Cells[0].Value);

		} else {

			dataGridView2.EndEdit();
			//Trace.WriteLine(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
			_service.SetRuleEnabled(dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString(),(bool)dataGridView2.Rows[e.RowIndex].Cells[0].Value);
		}

	}

	private void buttonedit_Click(object sender,EventArgs e) {

		//Trace.WriteLine(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString());

		if(tabControl1.SelectedIndex == 0) {

			EditRuleForm F = new EditRuleForm();
			F.Owner = this;
			F.Names = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
			F.Description = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
			F.Profiles = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
			F.Action = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
			F.Protocol = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value.ToString();
			F.InboundOutbound = 0;
			F.Apppath = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[11].Value.ToString();
			F.LocalAddresses = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[7].Value.ToString();
			F.LocalPorts = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[8].Value.ToString();
			F.RemoteAddresses = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[9].Value.ToString();
			F.RemotePorts = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[10].Value.ToString();
			F.service = _service;
			F.ShowDialog();

		} else {

			EditRuleForm F = new EditRuleForm();
			F.Owner = this;
			F.Names = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[1].Value.ToString();
			F.Description = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[2].Value.ToString();
			F.Profiles = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[4].Value.ToString();
			F.Action = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[5].Value.ToString();
			F.Protocol = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[6].Value.ToString();
			F.InboundOutbound = 1;
			F.Apppath = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[11].Value.ToString();
			F.LocalAddresses = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[7].Value.ToString();
			F.LocalPorts = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[8].Value.ToString();
			F.RemoteAddresses = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[9].Value.ToString();
			F.RemotePorts = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[10].Value.ToString();
			F.service = _service;
			F.ShowDialog();
		}
	}

	

	
}
