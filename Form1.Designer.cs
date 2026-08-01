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
		_grid = new DataGridView();
		panel1 = new Panel();
		_searchBox = new TextBox();
		labelSearch = new Label();
		buttonExportJSON = new Button();
		buttonDelete = new Button();
		buttonDisable = new Button();
		buttonEnable = new Button();
		buttonAddRule = new Button();
		buttonRefresh = new Button();
		((System.ComponentModel.ISupportInitialize)_grid).BeginInit();
		panel1.SuspendLayout();
		SuspendLayout();
		// 
		// _grid
		// 
		_grid.AllowUserToAddRows = false;
		_grid.AllowUserToResizeColumns = false;
		_grid.AllowUserToResizeRows = false;
		_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		_grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		_grid.BackgroundColor = Color.White;
		_grid.BorderStyle = BorderStyle.None;
		_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		_grid.ColumnHeadersVisible = false;
		_grid.Dock = DockStyle.Fill;
		_grid.Location = new Point(0,52);
		_grid.Name = "_grid";
		_grid.RowHeadersVisible = false;
		_grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		_grid.Size = new Size(1184,509);
		_grid.TabIndex = 0;
		_grid.TabStop = false;
		// 
		// panel1
		// 
		panel1.Controls.Add(_searchBox);
		panel1.Controls.Add(labelSearch);
		panel1.Controls.Add(buttonExportJSON);
		panel1.Controls.Add(buttonDelete);
		panel1.Controls.Add(buttonDisable);
		panel1.Controls.Add(buttonEnable);
		panel1.Controls.Add(buttonAddRule);
		panel1.Controls.Add(buttonRefresh);
		panel1.Dock = DockStyle.Top;
		panel1.Location = new Point(0,0);
		panel1.Name = "panel1";
		panel1.Size = new Size(1184,52);
		panel1.TabIndex = 1;
		// 
		// _searchBox
		// 
		_searchBox.Location = new Point(662,12);
		_searchBox.Name = "_searchBox";
		_searchBox.Size = new Size(394,23);
		_searchBox.TabIndex = 7;
		_searchBox.TabStop = false;
		_searchBox.WordWrap = false;
		_searchBox.TextChanged += _searchBox_TextChanged;
		// 
		// labelSearch
		// 
		labelSearch.AutoSize = true;
		labelSearch.Location = new Point(601,16);
		labelSearch.Name = "labelSearch";
		labelSearch.Size = new Size(45,15);
		labelSearch.TabIndex = 6;
		labelSearch.Text = "Search";
		// 
		// buttonExportJSON
		// 
		buttonExportJSON.Location = new Point(483,12);
		buttonExportJSON.Name = "buttonExportJSON";
		buttonExportJSON.Size = new Size(75,23);
		buttonExportJSON.TabIndex = 5;
		buttonExportJSON.TabStop = false;
		buttonExportJSON.Text = "Export JSON";
		buttonExportJSON.UseVisualStyleBackColor = true;
		// 
		// buttonDelete
		// 
		buttonDelete.Location = new Point(387,12);
		buttonDelete.Name = "buttonDelete";
		buttonDelete.Size = new Size(75,23);
		buttonDelete.TabIndex = 4;
		buttonDelete.TabStop = false;
		buttonDelete.Text = "Delete";
		buttonDelete.UseVisualStyleBackColor = true;
		// 
		// buttonDisable
		// 
		buttonDisable.Location = new Point(296,12);
		buttonDisable.Name = "buttonDisable";
		buttonDisable.Size = new Size(75,23);
		buttonDisable.TabIndex = 3;
		buttonDisable.TabStop = false;
		buttonDisable.Text = "Disable";
		buttonDisable.UseVisualStyleBackColor = true;
		// 
		// buttonEnable
		// 
		buttonEnable.Location = new Point(203,12);
		buttonEnable.Name = "buttonEnable";
		buttonEnable.Size = new Size(75,23);
		buttonEnable.TabIndex = 2;
		buttonEnable.TabStop = false;
		buttonEnable.Text = "Enable";
		buttonEnable.UseVisualStyleBackColor = true;
		// 
		// buttonAddRule
		// 
		buttonAddRule.Location = new Point(108,12);
		buttonAddRule.Name = "buttonAddRule";
		buttonAddRule.Size = new Size(75,23);
		buttonAddRule.TabIndex = 1;
		buttonAddRule.TabStop = false;
		buttonAddRule.Text = "Add Rule";
		buttonAddRule.UseVisualStyleBackColor = true;
		// 
		// buttonRefresh
		// 
		buttonRefresh.Location = new Point(12,12);
		buttonRefresh.Name = "buttonRefresh";
		buttonRefresh.Size = new Size(75,23);
		buttonRefresh.TabIndex = 0;
		buttonRefresh.TabStop = false;
		buttonRefresh.Text = "Refresh";
		buttonRefresh.UseVisualStyleBackColor = true;
		// 
		// Form1
		// 
		AutoScaleDimensions = new SizeF(7F,15F);
		AutoScaleMode = AutoScaleMode.Font;
		AutoSizeMode = AutoSizeMode.GrowAndShrink;
		ClientSize = new Size(1184,561);
		Controls.Add(_grid);
		Controls.Add(panel1);
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "Form1";
		ShowIcon = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "Firewall Manager";
		Load += Form1_Load;
		((System.ComponentModel.ISupportInitialize)_grid).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		ResumeLayout(false);
	}

	#endregion

	private DataGridView _grid;
	private Panel panel1;
	private Button buttonRefresh;
	private Button buttonAddRule;
	private Button buttonEnable;
	private Button buttonDisable;
	private Button buttonDelete;
	private Button buttonExportJSON;
	private Label labelSearch;
	private TextBox _searchBox;
}
