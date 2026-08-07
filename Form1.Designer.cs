namespace AdvancedFirewallManager;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

	#region Windows Form Designer generated code

	/// <summary>
	///  Required method for Designer support - do not modify
	///  the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent() {
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
		dataGridView1 = new DataGridView();
		Enabled1 = new DataGridViewCheckBoxColumn();
		Name1 = new DataGridViewTextBoxColumn();
		Description1 = new DataGridViewTextBoxColumn();
		Grouping1 = new DataGridViewTextBoxColumn();
		Profiles1 = new DataGridViewTextBoxColumn();
		Action1 = new DataGridViewTextBoxColumn();
		Protocol1 = new DataGridViewTextBoxColumn();
		LocalAddresses1 = new DataGridViewTextBoxColumn();
		LocalPorts1 = new DataGridViewTextBoxColumn();
		RemoteAddresses1 = new DataGridViewTextBoxColumn();
		RemotePorts1 = new DataGridViewTextBoxColumn();
		ApplicationPath1 = new DataGridViewTextBoxColumn();
		panel1 = new Panel();
		buttonedit = new Button();
		_searchBox = new TextBox();
		labelSearch = new Label();
		buttonDelete = new Button();
		buttonAddRule = new Button();
		buttonRefresh = new Button();
		tabControl1 = new TabControl();
		tabPage1 = new TabPage();
		tabPage2 = new TabPage();
		dataGridView2 = new DataGridView();
		dataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
		dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
		dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
		backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
		((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
		panel1.SuspendLayout();
		tabControl1.SuspendLayout();
		tabPage1.SuspendLayout();
		tabPage2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
		SuspendLayout();
		// 
		// dataGridView1
		// 
		dataGridView1.AllowUserToAddRows = false;
		dataGridView1.AllowUserToResizeColumns = false;
		dataGridView1.AllowUserToResizeRows = false;
		dataGridView1.BackgroundColor = Color.White;
		dataGridView1.BorderStyle = BorderStyle.None;
		dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Enabled1,Name1,Description1,Grouping1,Profiles1,Action1,Protocol1,LocalAddresses1,LocalPorts1,RemoteAddresses1,RemotePorts1,ApplicationPath1 });
		dataGridView1.Dock = DockStyle.Fill;
		dataGridView1.Location = new Point(3,3);
		dataGridView1.Name = "dataGridView1";
		dataGridView1.RowHeadersVisible = false;
		dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dataGridView1.Size = new Size(1170,597);
		dataGridView1.TabIndex = 0;
		dataGridView1.TabStop = false;
		dataGridView1.CellContentClick += dataGridView1_CellContentClick;
		// 
		// Enabled1
		// 
		Enabled1.HeaderText = "是否啓用";
		Enabled1.Name = "Enabled1";
		Enabled1.Resizable = DataGridViewTriState.False;
		Enabled1.SortMode = DataGridViewColumnSortMode.Automatic;
		Enabled1.Width = 80;
		// 
		// Name1
		// 
		Name1.HeaderText = "名稱";
		Name1.Name = "Name1";
		Name1.ReadOnly = true;
		Name1.Width = 300;
		// 
		// Description1
		// 
		Description1.HeaderText = "描述";
		Description1.Name = "Description1";
		Description1.ReadOnly = true;
		Description1.Width = 400;
		// 
		// Grouping1
		// 
		Grouping1.HeaderText = "群組";
		Grouping1.Name = "Grouping1";
		Grouping1.ReadOnly = true;
		Grouping1.Width = 200;
		// 
		// Profiles1
		// 
		Profiles1.HeaderText = "設定檔";
		Profiles1.Name = "Profiles1";
		Profiles1.ReadOnly = true;
		Profiles1.Width = 200;
		// 
		// Action1
		// 
		Action1.HeaderText = "動作";
		Action1.Name = "Action1";
		Action1.ReadOnly = true;
		Action1.Width = 97;
		// 
		// Protocol1
		// 
		Protocol1.HeaderText = "協定";
		Protocol1.Name = "Protocol1";
		Protocol1.ReadOnly = true;
		Protocol1.Width = 98;
		// 
		// LocalAddresses1
		// 
		LocalAddresses1.HeaderText = "本機位址";
		LocalAddresses1.Name = "LocalAddresses1";
		LocalAddresses1.ReadOnly = true;
		LocalAddresses1.Width = 200;
		// 
		// LocalPorts1
		// 
		LocalPorts1.HeaderText = "本機埠";
		LocalPorts1.Name = "LocalPorts1";
		LocalPorts1.ReadOnly = true;
		LocalPorts1.Width = 98;
		// 
		// RemoteAddresses1
		// 
		RemoteAddresses1.HeaderText = "遠端位址";
		RemoteAddresses1.Name = "RemoteAddresses1";
		RemoteAddresses1.ReadOnly = true;
		RemoteAddresses1.Width = 200;
		// 
		// RemotePorts1
		// 
		RemotePorts1.HeaderText = "遠端埠";
		RemotePorts1.Name = "RemotePorts1";
		RemotePorts1.ReadOnly = true;
		RemotePorts1.Width = 98;
		// 
		// ApplicationPath1
		// 
		ApplicationPath1.HeaderText = "應用程式路徑";
		ApplicationPath1.Name = "ApplicationPath1";
		ApplicationPath1.ReadOnly = true;
		ApplicationPath1.Width = 200;
		// 
		// panel1
		// 
		panel1.Controls.Add(buttonedit);
		panel1.Controls.Add(_searchBox);
		panel1.Controls.Add(labelSearch);
		panel1.Controls.Add(buttonDelete);
		panel1.Controls.Add(buttonAddRule);
		panel1.Controls.Add(buttonRefresh);
		panel1.Dock = DockStyle.Top;
		panel1.Location = new Point(0,0);
		panel1.Name = "panel1";
		panel1.Size = new Size(1184,30);
		panel1.TabIndex = 1;
		// 
		// buttonedit
		// 
		buttonedit.Location = new Point(195,3);
		buttonedit.Name = "buttonedit";
		buttonedit.Size = new Size(75,23);
		buttonedit.TabIndex = 8;
		buttonedit.Text = "編輯";
		buttonedit.UseVisualStyleBackColor = true;
		buttonedit.Click += buttonedit_Click;
		// 
		// _searchBox
		// 
		_searchBox.Location = new Point(443,3);
		_searchBox.Name = "_searchBox";
		_searchBox.PlaceholderText = "請輸入關鍵字搜尋...";
		_searchBox.Size = new Size(394,23);
		_searchBox.TabIndex = 7;
		_searchBox.TabStop = false;
		_searchBox.WordWrap = false;
		_searchBox.KeyUp += _searchBox_KeyUp;
		// 
		// labelSearch
		// 
		labelSearch.AutoSize = true;
		labelSearch.Location = new Point(382,7);
		labelSearch.Name = "labelSearch";
		labelSearch.Size = new Size(31,15);
		labelSearch.TabIndex = 6;
		labelSearch.Text = "搜尋";
		// 
		// buttonDelete
		// 
		buttonDelete.Location = new Point(285,3);
		buttonDelete.Name = "buttonDelete";
		buttonDelete.Size = new Size(75,23);
		buttonDelete.TabIndex = 4;
		buttonDelete.TabStop = false;
		buttonDelete.Text = "刪除";
		buttonDelete.UseVisualStyleBackColor = true;
		buttonDelete.Click += buttonDelete_Click;
		// 
		// buttonAddRule
		// 
		buttonAddRule.Location = new Point(103,3);
		buttonAddRule.Name = "buttonAddRule";
		buttonAddRule.Size = new Size(75,23);
		buttonAddRule.TabIndex = 1;
		buttonAddRule.TabStop = false;
		buttonAddRule.Text = "新增";
		buttonAddRule.UseVisualStyleBackColor = true;
		buttonAddRule.Click += buttonAddRule_Click;
		// 
		// buttonRefresh
		// 
		buttonRefresh.Location = new Point(7,3);
		buttonRefresh.Name = "buttonRefresh";
		buttonRefresh.Size = new Size(75,23);
		buttonRefresh.TabIndex = 0;
		buttonRefresh.TabStop = false;
		buttonRefresh.Text = "重新整理";
		buttonRefresh.UseVisualStyleBackColor = true;
		buttonRefresh.Click += buttonRefresh_Click;
		// 
		// tabControl1
		// 
		tabControl1.Controls.Add(tabPage1);
		tabControl1.Controls.Add(tabPage2);
		tabControl1.Dock = DockStyle.Fill;
		tabControl1.Location = new Point(0,30);
		tabControl1.Name = "tabControl1";
		tabControl1.SelectedIndex = 0;
		tabControl1.Size = new Size(1184,631);
		tabControl1.TabIndex = 2;
		tabControl1.TabStop = false;
		// 
		// tabPage1
		// 
		tabPage1.Controls.Add(dataGridView1);
		tabPage1.Location = new Point(4,24);
		tabPage1.Name = "tabPage1";
		tabPage1.Padding = new Padding(3);
		tabPage1.Size = new Size(1176,603);
		tabPage1.TabIndex = 0;
		tabPage1.Text = "連入";
		tabPage1.ToolTipText = "連入";
		tabPage1.UseVisualStyleBackColor = true;
		// 
		// tabPage2
		// 
		tabPage2.Controls.Add(dataGridView2);
		tabPage2.Location = new Point(4,24);
		tabPage2.Name = "tabPage2";
		tabPage2.Padding = new Padding(3);
		tabPage2.Size = new Size(1176,603);
		tabPage2.TabIndex = 1;
		tabPage2.Text = "連出";
		tabPage2.ToolTipText = "連出";
		tabPage2.UseVisualStyleBackColor = true;
		// 
		// dataGridView2
		// 
		dataGridView2.AllowUserToAddRows = false;
		dataGridView2.AllowUserToResizeColumns = false;
		dataGridView2.AllowUserToResizeRows = false;
		dataGridView2.BackgroundColor = Color.White;
		dataGridView2.BorderStyle = BorderStyle.None;
		dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewCheckBoxColumn1,dataGridViewTextBoxColumn1,dataGridViewTextBoxColumn2,dataGridViewTextBoxColumn3,dataGridViewTextBoxColumn4,dataGridViewTextBoxColumn5,dataGridViewTextBoxColumn6,dataGridViewTextBoxColumn7,dataGridViewTextBoxColumn8,dataGridViewTextBoxColumn9,dataGridViewTextBoxColumn10,dataGridViewTextBoxColumn11 });
		dataGridView2.Dock = DockStyle.Fill;
		dataGridView2.Location = new Point(3,3);
		dataGridView2.Name = "dataGridView2";
		dataGridView2.RowHeadersVisible = false;
		dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dataGridView2.Size = new Size(1170,597);
		dataGridView2.TabIndex = 1;
		dataGridView2.TabStop = false;
		dataGridView2.CellContentClick += dataGridView1_CellContentClick;
		// 
		// dataGridViewCheckBoxColumn1
		// 
		dataGridViewCheckBoxColumn1.HeaderText = "是否啓用";
		dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
		dataGridViewCheckBoxColumn1.Resizable = DataGridViewTriState.False;
		dataGridViewCheckBoxColumn1.SortMode = DataGridViewColumnSortMode.Automatic;
		dataGridViewCheckBoxColumn1.Width = 80;
		// 
		// dataGridViewTextBoxColumn1
		// 
		dataGridViewTextBoxColumn1.HeaderText = "名稱";
		dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
		dataGridViewTextBoxColumn1.ReadOnly = true;
		dataGridViewTextBoxColumn1.Width = 300;
		// 
		// dataGridViewTextBoxColumn2
		// 
		dataGridViewTextBoxColumn2.HeaderText = "描述";
		dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
		dataGridViewTextBoxColumn2.ReadOnly = true;
		dataGridViewTextBoxColumn2.Width = 400;
		// 
		// dataGridViewTextBoxColumn3
		// 
		dataGridViewTextBoxColumn3.HeaderText = "群組";
		dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
		dataGridViewTextBoxColumn3.ReadOnly = true;
		dataGridViewTextBoxColumn3.Width = 200;
		// 
		// dataGridViewTextBoxColumn4
		// 
		dataGridViewTextBoxColumn4.HeaderText = "設定檔";
		dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
		dataGridViewTextBoxColumn4.ReadOnly = true;
		dataGridViewTextBoxColumn4.Width = 200;
		// 
		// dataGridViewTextBoxColumn5
		// 
		dataGridViewTextBoxColumn5.HeaderText = "動作";
		dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
		dataGridViewTextBoxColumn5.ReadOnly = true;
		dataGridViewTextBoxColumn5.Width = 97;
		// 
		// dataGridViewTextBoxColumn6
		// 
		dataGridViewTextBoxColumn6.HeaderText = "協定";
		dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
		dataGridViewTextBoxColumn6.ReadOnly = true;
		dataGridViewTextBoxColumn6.Width = 98;
		// 
		// dataGridViewTextBoxColumn7
		// 
		dataGridViewTextBoxColumn7.HeaderText = "本機位址";
		dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
		dataGridViewTextBoxColumn7.ReadOnly = true;
		dataGridViewTextBoxColumn7.Width = 200;
		// 
		// dataGridViewTextBoxColumn8
		// 
		dataGridViewTextBoxColumn8.HeaderText = "本機埠";
		dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
		dataGridViewTextBoxColumn8.ReadOnly = true;
		dataGridViewTextBoxColumn8.Width = 98;
		// 
		// dataGridViewTextBoxColumn9
		// 
		dataGridViewTextBoxColumn9.HeaderText = "遠端位址";
		dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
		dataGridViewTextBoxColumn9.ReadOnly = true;
		dataGridViewTextBoxColumn9.Width = 200;
		// 
		// dataGridViewTextBoxColumn10
		// 
		dataGridViewTextBoxColumn10.HeaderText = "遠端埠";
		dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
		dataGridViewTextBoxColumn10.ReadOnly = true;
		dataGridViewTextBoxColumn10.Width = 98;
		// 
		// dataGridViewTextBoxColumn11
		// 
		dataGridViewTextBoxColumn11.HeaderText = "應用程式路徑";
		dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
		dataGridViewTextBoxColumn11.ReadOnly = true;
		dataGridViewTextBoxColumn11.Width = 200;
		// 
		// backgroundWorker1
		// 
		backgroundWorker1.WorkerReportsProgress = true;
		backgroundWorker1.WorkerSupportsCancellation = true;
		backgroundWorker1.DoWork += backgroundWorker1_DoWork;
		backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
		// 
		// Form1
		// 
		AutoScaleDimensions = new SizeF(7F,15F);
		AutoScaleMode = AutoScaleMode.Font;
		AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ClientSize = new Size(1184,661);
		Controls.Add(tabControl1);
		Controls.Add(panel1);
		Icon = (Icon)resources.GetObject("$this.Icon");
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "Form1";
		StartPosition = FormStartPosition.CenterScreen;
		Text = "Firewall Manager";
		Load += Form1_Load;
		((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		tabControl1.ResumeLayout(false);
		tabPage1.ResumeLayout(false);
		tabPage2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
		ResumeLayout(false);
	}

	#endregion
	private Panel panel1;
	private Button buttonRefresh;
	private Button buttonAddRule;
	private Button buttonDelete;
	private Label labelSearch;
	private TextBox _searchBox;
	private TabControl tabControl1;
	private TabPage tabPage1;
	private TabPage tabPage2;
	public DataGridView dataGridView1;
	public DataGridView dataGridView2;
	public System.ComponentModel.BackgroundWorker backgroundWorker1;
	private DataGridViewCheckBoxColumn Enabled1;
	private DataGridViewTextBoxColumn Name1;
	private DataGridViewTextBoxColumn Description1;
	private DataGridViewTextBoxColumn Grouping1;
	private DataGridViewTextBoxColumn Profiles1;
	private DataGridViewTextBoxColumn Action1;
	private DataGridViewTextBoxColumn Protocol1;
	private DataGridViewTextBoxColumn LocalAddresses1;
	private DataGridViewTextBoxColumn LocalPorts1;
	private DataGridViewTextBoxColumn RemoteAddresses1;
	private DataGridViewTextBoxColumn RemotePorts1;
	private DataGridViewTextBoxColumn ApplicationPath1;
	private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
	private Button buttonedit;
}
