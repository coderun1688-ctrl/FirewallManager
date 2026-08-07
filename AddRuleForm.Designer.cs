namespace AdvancedFirewallManager {
	partial class AddRuleForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			label_name = new Label();
			textBox_path = new TextBox();
			button_Browse = new Button();
			openFileDialog1 = new OpenFileDialog();
			checkBox_allow = new CheckBox();
			checkBox_Inbound = new CheckBox();
			buttonOK = new Button();
			textBoxname = new TextBox();
			labelpath = new Label();
			checkBox_block = new CheckBox();
			panel1 = new Panel();
			checkBox_Outbound = new CheckBox();
			panel2 = new Panel();
			richTextBoxDescription = new RichTextBox();
			labelDescription = new Label();
			labelAction = new Label();
			labelcat = new Label();
			labelProfile = new Label();
			checkBoxDomain = new CheckBox();
			checkBoxPrivate = new CheckBox();
			checkBoxPublic = new CheckBox();
			panel3 = new Panel();
			labelProtocol = new Label();
			comboBoxProtocol = new ComboBox();
			labelLocalAddresses = new Label();
			textBoxLocalAddresses = new TextBox();
			textBoxLocalPorts = new TextBox();
			labelLocalPorts = new Label();
			labelRemoteAddresses = new Label();
			textBoxRemoteAddresses = new TextBox();
			labelRemotePorts = new Label();
			textBoxRemotePorts = new TextBox();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			panel3.SuspendLayout();
			SuspendLayout();
			// 
			// label_name
			// 
			label_name.AutoSize = true;
			label_name.Location = new Point(12,18);
			label_name.Name = "label_name";
			label_name.Size = new Size(31,15);
			label_name.TabIndex = 0;
			label_name.Text = "名稱";
			// 
			// textBox_path
			// 
			textBox_path.Location = new Point(89,114);
			textBox_path.Name = "textBox_path";
			textBox_path.PlaceholderText = "請選檔案...";
			textBox_path.ReadOnly = true;
			textBox_path.Size = new Size(390,23);
			textBox_path.TabIndex = 1;
			textBox_path.TabStop = false;
			textBox_path.Text = "C:\\c#\\WinHostEdit\\WinHostEdit\\bin\\Release\\net10.0-windows\\WinHostEdit.exe";
			// 
			// button_Browse
			// 
			button_Browse.Location = new Point(485,113);
			button_Browse.Name = "button_Browse";
			button_Browse.Size = new Size(75,23);
			button_Browse.TabIndex = 2;
			button_Browse.TabStop = false;
			button_Browse.Text = "瀏覽檔案...";
			button_Browse.UseVisualStyleBackColor = true;
			button_Browse.Click += button_Browse_Click;
			// 
			// openFileDialog1
			// 
			openFileDialog1.Filter = "Executable (*.exe)|*.exe|All files (*.*)|*.*";
			openFileDialog1.Title = "開啓";
			// 
			// checkBox_allow
			// 
			checkBox_allow.AutoSize = true;
			checkBox_allow.Checked = true;
			checkBox_allow.CheckState = CheckState.Checked;
			checkBox_allow.Location = new Point(3,5);
			checkBox_allow.Name = "checkBox_allow";
			checkBox_allow.Size = new Size(50,19);
			checkBox_allow.TabIndex = 3;
			checkBox_allow.TabStop = false;
			checkBox_allow.Text = "允許";
			checkBox_allow.UseVisualStyleBackColor = true;
			checkBox_allow.CheckedChanged += allowblock;
			// 
			// checkBox_Inbound
			// 
			checkBox_Inbound.AutoSize = true;
			checkBox_Inbound.Checked = true;
			checkBox_Inbound.CheckState = CheckState.Checked;
			checkBox_Inbound.Location = new Point(3,6);
			checkBox_Inbound.Name = "checkBox_Inbound";
			checkBox_Inbound.Size = new Size(50,19);
			checkBox_Inbound.TabIndex = 4;
			checkBox_Inbound.TabStop = false;
			checkBox_Inbound.Text = "連入";
			checkBox_Inbound.UseVisualStyleBackColor = true;
			checkBox_Inbound.CheckedChanged += Inandout;
			// 
			// buttonOK
			// 
			buttonOK.Location = new Point(485,326);
			buttonOK.Name = "buttonOK";
			buttonOK.Size = new Size(75,23);
			buttonOK.TabIndex = 5;
			buttonOK.TabStop = false;
			buttonOK.Text = "確定";
			buttonOK.UseVisualStyleBackColor = true;
			buttonOK.Click += buttonOK_Click;
			// 
			// textBoxname
			// 
			textBoxname.Location = new Point(89,15);
			textBoxname.Name = "textBoxname";
			textBoxname.Size = new Size(471,23);
			textBoxname.TabIndex = 6;
			textBoxname.TabStop = false;
			textBoxname.Text = "WinHostEdit";
			// 
			// labelpath
			// 
			labelpath.AutoSize = true;
			labelpath.Location = new Point(12,118);
			labelpath.Name = "labelpath";
			labelpath.Size = new Size(55,15);
			labelpath.TabIndex = 7;
			labelpath.Text = "應用程式";
			// 
			// checkBox_block
			// 
			checkBox_block.AutoSize = true;
			checkBox_block.Location = new Point(95,5);
			checkBox_block.Name = "checkBox_block";
			checkBox_block.Size = new Size(50,19);
			checkBox_block.TabIndex = 8;
			checkBox_block.Text = "封鎖";
			checkBox_block.UseVisualStyleBackColor = true;
			checkBox_block.CheckedChanged += allowblock;
			// 
			// panel1
			// 
			panel1.Controls.Add(checkBox_allow);
			panel1.Controls.Add(checkBox_block);
			panel1.Location = new Point(92,151);
			panel1.Name = "panel1";
			panel1.Size = new Size(152,30);
			panel1.TabIndex = 9;
			// 
			// checkBox_Outbound
			// 
			checkBox_Outbound.AutoSize = true;
			checkBox_Outbound.Location = new Point(95,6);
			checkBox_Outbound.Name = "checkBox_Outbound";
			checkBox_Outbound.Size = new Size(50,19);
			checkBox_Outbound.TabIndex = 10;
			checkBox_Outbound.TabStop = false;
			checkBox_Outbound.Text = "連出";
			checkBox_Outbound.UseVisualStyleBackColor = true;
			checkBox_Outbound.CheckedChanged += Inandout;
			// 
			// panel2
			// 
			panel2.Controls.Add(checkBox_Inbound);
			panel2.Controls.Add(checkBox_Outbound);
			panel2.Location = new Point(406,152);
			panel2.Name = "panel2";
			panel2.Size = new Size(152,30);
			panel2.TabIndex = 11;
			// 
			// richTextBoxDescription
			// 
			richTextBoxDescription.BorderStyle = BorderStyle.None;
			richTextBoxDescription.Location = new Point(89,44);
			richTextBoxDescription.Name = "richTextBoxDescription";
			richTextBoxDescription.Size = new Size(471,53);
			richTextBoxDescription.TabIndex = 12;
			richTextBoxDescription.TabStop = false;
			richTextBoxDescription.Text = "來自 WinHostEdit 取公網 IP";
			// 
			// labelDescription
			// 
			labelDescription.AutoSize = true;
			labelDescription.Location = new Point(12,44);
			labelDescription.Name = "labelDescription";
			labelDescription.Size = new Size(31,15);
			labelDescription.TabIndex = 13;
			labelDescription.Text = "描述";
			// 
			// labelAction
			// 
			labelAction.AutoSize = true;
			labelAction.Location = new Point(12,160);
			labelAction.Name = "labelAction";
			labelAction.Size = new Size(31,15);
			labelAction.TabIndex = 14;
			labelAction.Text = "動作";
			// 
			// labelcat
			// 
			labelcat.AutoSize = true;
			labelcat.Location = new Point(326,160);
			labelcat.Name = "labelcat";
			labelcat.Size = new Size(31,15);
			labelcat.TabIndex = 15;
			labelcat.Text = "類別";
			// 
			// labelProfile
			// 
			labelProfile.AutoSize = true;
			labelProfile.Location = new Point(12,198);
			labelProfile.Name = "labelProfile";
			labelProfile.Size = new Size(43,15);
			labelProfile.TabIndex = 16;
			labelProfile.Text = "設定檔";
			// 
			// checkBoxDomain
			// 
			checkBoxDomain.AutoSize = true;
			checkBoxDomain.Location = new Point(3,6);
			checkBoxDomain.Name = "checkBoxDomain";
			checkBoxDomain.Size = new Size(50,19);
			checkBoxDomain.TabIndex = 17;
			checkBoxDomain.Text = "域名";
			checkBoxDomain.UseVisualStyleBackColor = true;
			// 
			// checkBoxPrivate
			// 
			checkBoxPrivate.AutoSize = true;
			checkBoxPrivate.Location = new Point(64,6);
			checkBoxPrivate.Name = "checkBoxPrivate";
			checkBoxPrivate.Size = new Size(50,19);
			checkBoxPrivate.TabIndex = 18;
			checkBoxPrivate.Text = "私人";
			checkBoxPrivate.UseVisualStyleBackColor = true;
			// 
			// checkBoxPublic
			// 
			checkBoxPublic.AutoSize = true;
			checkBoxPublic.Location = new Point(121,6);
			checkBoxPublic.Name = "checkBoxPublic";
			checkBoxPublic.Size = new Size(50,19);
			checkBoxPublic.TabIndex = 19;
			checkBoxPublic.Text = "公開";
			checkBoxPublic.UseVisualStyleBackColor = true;
			// 
			// panel3
			// 
			panel3.Controls.Add(checkBoxDomain);
			panel3.Controls.Add(checkBoxPublic);
			panel3.Controls.Add(checkBoxPrivate);
			panel3.Location = new Point(92,186);
			panel3.Name = "panel3";
			panel3.Size = new Size(181,30);
			panel3.TabIndex = 20;
			// 
			// labelProtocol
			// 
			labelProtocol.AutoSize = true;
			labelProtocol.Location = new Point(326,194);
			labelProtocol.Name = "labelProtocol";
			labelProtocol.Size = new Size(31,15);
			labelProtocol.TabIndex = 21;
			labelProtocol.Text = "協定";
			// 
			// comboBoxProtocol
			// 
			comboBoxProtocol.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBoxProtocol.FormattingEnabled = true;
			comboBoxProtocol.Location = new Point(405,188);
			comboBoxProtocol.Name = "comboBoxProtocol";
			comboBoxProtocol.Size = new Size(153,23);
			comboBoxProtocol.TabIndex = 22;
			// 
			// labelLocalAddresses
			// 
			labelLocalAddresses.AutoSize = true;
			labelLocalAddresses.Location = new Point(12,231);
			labelLocalAddresses.Name = "labelLocalAddresses";
			labelLocalAddresses.Size = new Size(55,15);
			labelLocalAddresses.TabIndex = 23;
			labelLocalAddresses.Text = "本機位址";
			// 
			// textBoxLocalAddresses
			// 
			textBoxLocalAddresses.Location = new Point(89,226);
			textBoxLocalAddresses.Name = "textBoxLocalAddresses";
			textBoxLocalAddresses.Size = new Size(201,23);
			textBoxLocalAddresses.TabIndex = 24;
			// 
			// textBoxLocalPorts
			// 
			textBoxLocalPorts.Location = new Point(405,224);
			textBoxLocalPorts.Name = "textBoxLocalPorts";
			textBoxLocalPorts.Size = new Size(153,23);
			textBoxLocalPorts.TabIndex = 25;
			// 
			// labelLocalPorts
			// 
			labelLocalPorts.AutoSize = true;
			labelLocalPorts.Location = new Point(326,230);
			labelLocalPorts.Name = "labelLocalPorts";
			labelLocalPorts.Size = new Size(43,15);
			labelLocalPorts.TabIndex = 26;
			labelLocalPorts.Text = "本機埠";
			// 
			// labelRemoteAddresses
			// 
			labelRemoteAddresses.AutoSize = true;
			labelRemoteAddresses.Location = new Point(13,263);
			labelRemoteAddresses.Name = "labelRemoteAddresses";
			labelRemoteAddresses.Size = new Size(55,15);
			labelRemoteAddresses.TabIndex = 27;
			labelRemoteAddresses.Text = "遠端位址";
			// 
			// textBoxRemoteAddresses
			// 
			textBoxRemoteAddresses.Location = new Point(89,259);
			textBoxRemoteAddresses.Name = "textBoxRemoteAddresses";
			textBoxRemoteAddresses.Size = new Size(201,23);
			textBoxRemoteAddresses.TabIndex = 28;
			// 
			// labelRemotePorts
			// 
			labelRemotePorts.AutoSize = true;
			labelRemotePorts.Location = new Point(327,263);
			labelRemotePorts.Name = "labelRemotePorts";
			labelRemotePorts.Size = new Size(43,15);
			labelRemotePorts.TabIndex = 29;
			labelRemotePorts.Text = "遠端埠";
			// 
			// textBoxRemotePorts
			// 
			textBoxRemotePorts.Location = new Point(405,258);
			textBoxRemotePorts.Name = "textBoxRemotePorts";
			textBoxRemotePorts.Size = new Size(153,23);
			textBoxRemotePorts.TabIndex = 30;
			// 
			// AddRuleForm
			// 
			AutoScaleDimensions = new SizeF(7F,15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;
			ClientSize = new Size(584,361);
			Controls.Add(textBoxRemotePorts);
			Controls.Add(labelRemotePorts);
			Controls.Add(textBoxRemoteAddresses);
			Controls.Add(labelRemoteAddresses);
			Controls.Add(labelLocalPorts);
			Controls.Add(textBoxLocalPorts);
			Controls.Add(textBoxLocalAddresses);
			Controls.Add(labelLocalAddresses);
			Controls.Add(comboBoxProtocol);
			Controls.Add(labelProtocol);
			Controls.Add(panel3);
			Controls.Add(labelProfile);
			Controls.Add(labelcat);
			Controls.Add(labelAction);
			Controls.Add(labelDescription);
			Controls.Add(richTextBoxDescription);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Controls.Add(labelpath);
			Controls.Add(textBoxname);
			Controls.Add(buttonOK);
			Controls.Add(button_Browse);
			Controls.Add(textBox_path);
			Controls.Add(label_name);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "AddRuleForm";
			ShowIcon = false;
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Add Firewall Rule";
			Load += AddRuleForm_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		public Label label_name;
		private TextBox textBox_path;
		private Button button_Browse;
		private OpenFileDialog openFileDialog1;
		private CheckBox checkBox_allow;
		private CheckBox checkBox_Inbound;
		private Button buttonOK;
		private TextBox textBoxname;
		private Label labelpath;
		private CheckBox checkBox_block;
		private Panel panel1;
		private CheckBox checkBox_Outbound;
		private Panel panel2;
		private RichTextBox richTextBoxDescription;
		private Label labelDescription;
		private Label labelAction;
		private Label labelcat;
		private Label labelProfile;
		private CheckBox checkBoxDomain;
		private CheckBox checkBoxPrivate;
		private CheckBox checkBoxPublic;
		private Panel panel3;
		private Label labelProtocol;
		private ComboBox comboBoxProtocol;
		private Label labelLocalAddresses;
		private TextBox textBoxLocalAddresses;
		private TextBox textBoxLocalPorts;
		private Label labelLocalPorts;
		private Label labelRemoteAddresses;
		private TextBox textBoxRemoteAddresses;
		private Label labelRemotePorts;
		private TextBox textBoxRemotePorts;
	}
}