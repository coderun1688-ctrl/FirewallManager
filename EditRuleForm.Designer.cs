namespace AdvancedFirewallManager {
	partial class EditRuleForm {
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
			textBoxRemotePorts = new TextBox();
			labelRemotePorts = new Label();
			textBoxRemoteAddresses = new TextBox();
			labelRemoteAddresses = new Label();
			labelLocalPorts = new Label();
			textBoxLocalPorts = new TextBox();
			textBoxLocalAddresses = new TextBox();
			labelLocalAddresses = new Label();
			comboBoxProtocol = new ComboBox();
			labelProtocol = new Label();
			panel3 = new Panel();
			checkBoxDomain = new CheckBox();
			checkBoxPublic = new CheckBox();
			checkBoxPrivate = new CheckBox();
			labelProfile = new Label();
			labelcat = new Label();
			labelAction = new Label();
			labelDescription = new Label();
			richTextBoxDescription = new RichTextBox();
			panel2 = new Panel();
			checkBox_Inbound = new CheckBox();
			checkBox_Outbound = new CheckBox();
			panel1 = new Panel();
			checkBox_allow = new CheckBox();
			checkBox_block = new CheckBox();
			labelpath = new Label();
			textBoxname = new TextBox();
			buttonOK = new Button();
			button_Browse = new Button();
			textBox_path = new TextBox();
			label_name = new Label();
			openFileDialog1 = new OpenFileDialog();
			labeloldname = new Label();
			panel3.SuspendLayout();
			panel2.SuspendLayout();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// textBoxRemotePorts
			// 
			textBoxRemotePorts.Location = new Point(411,256);
			textBoxRemotePorts.Name = "textBoxRemotePorts";
			textBoxRemotePorts.Size = new Size(153,23);
			textBoxRemotePorts.TabIndex = 54;
			// 
			// labelRemotePorts
			// 
			labelRemotePorts.AutoSize = true;
			labelRemotePorts.Location = new Point(333,261);
			labelRemotePorts.Name = "labelRemotePorts";
			labelRemotePorts.Size = new Size(43,15);
			labelRemotePorts.TabIndex = 53;
			labelRemotePorts.Text = "遠端埠";
			// 
			// textBoxRemoteAddresses
			// 
			textBoxRemoteAddresses.Location = new Point(95,257);
			textBoxRemoteAddresses.Name = "textBoxRemoteAddresses";
			textBoxRemoteAddresses.Size = new Size(201,23);
			textBoxRemoteAddresses.TabIndex = 52;
			// 
			// labelRemoteAddresses
			// 
			labelRemoteAddresses.AutoSize = true;
			labelRemoteAddresses.Location = new Point(19,261);
			labelRemoteAddresses.Name = "labelRemoteAddresses";
			labelRemoteAddresses.Size = new Size(55,15);
			labelRemoteAddresses.TabIndex = 51;
			labelRemoteAddresses.Text = "遠端位址";
			// 
			// labelLocalPorts
			// 
			labelLocalPorts.AutoSize = true;
			labelLocalPorts.Location = new Point(332,228);
			labelLocalPorts.Name = "labelLocalPorts";
			labelLocalPorts.Size = new Size(43,15);
			labelLocalPorts.TabIndex = 50;
			labelLocalPorts.Text = "本機埠";
			// 
			// textBoxLocalPorts
			// 
			textBoxLocalPorts.Location = new Point(411,222);
			textBoxLocalPorts.Name = "textBoxLocalPorts";
			textBoxLocalPorts.Size = new Size(153,23);
			textBoxLocalPorts.TabIndex = 49;
			// 
			// textBoxLocalAddresses
			// 
			textBoxLocalAddresses.Location = new Point(95,224);
			textBoxLocalAddresses.Name = "textBoxLocalAddresses";
			textBoxLocalAddresses.Size = new Size(201,23);
			textBoxLocalAddresses.TabIndex = 48;
			// 
			// labelLocalAddresses
			// 
			labelLocalAddresses.AutoSize = true;
			labelLocalAddresses.Location = new Point(18,229);
			labelLocalAddresses.Name = "labelLocalAddresses";
			labelLocalAddresses.Size = new Size(55,15);
			labelLocalAddresses.TabIndex = 47;
			labelLocalAddresses.Text = "本機位址";
			// 
			// comboBoxProtocol
			// 
			comboBoxProtocol.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBoxProtocol.FormattingEnabled = true;
			comboBoxProtocol.Location = new Point(411,186);
			comboBoxProtocol.Name = "comboBoxProtocol";
			comboBoxProtocol.Size = new Size(153,23);
			comboBoxProtocol.TabIndex = 46;
			// 
			// labelProtocol
			// 
			labelProtocol.AutoSize = true;
			labelProtocol.Location = new Point(332,192);
			labelProtocol.Name = "labelProtocol";
			labelProtocol.Size = new Size(31,15);
			labelProtocol.TabIndex = 45;
			labelProtocol.Text = "協定";
			// 
			// panel3
			// 
			panel3.Controls.Add(checkBoxDomain);
			panel3.Controls.Add(checkBoxPublic);
			panel3.Controls.Add(checkBoxPrivate);
			panel3.Location = new Point(98,184);
			panel3.Name = "panel3";
			panel3.Size = new Size(181,30);
			panel3.TabIndex = 44;
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
			// labelProfile
			// 
			labelProfile.AutoSize = true;
			labelProfile.Location = new Point(18,196);
			labelProfile.Name = "labelProfile";
			labelProfile.Size = new Size(43,15);
			labelProfile.TabIndex = 43;
			labelProfile.Text = "設定檔";
			// 
			// labelcat
			// 
			labelcat.AutoSize = true;
			labelcat.Location = new Point(332,158);
			labelcat.Name = "labelcat";
			labelcat.Size = new Size(31,15);
			labelcat.TabIndex = 42;
			labelcat.Text = "類別";
			// 
			// labelAction
			// 
			labelAction.AutoSize = true;
			labelAction.Location = new Point(18,158);
			labelAction.Name = "labelAction";
			labelAction.Size = new Size(31,15);
			labelAction.TabIndex = 41;
			labelAction.Text = "動作";
			// 
			// labelDescription
			// 
			labelDescription.AutoSize = true;
			labelDescription.Location = new Point(18,42);
			labelDescription.Name = "labelDescription";
			labelDescription.Size = new Size(31,15);
			labelDescription.TabIndex = 40;
			labelDescription.Text = "描述";
			// 
			// richTextBoxDescription
			// 
			richTextBoxDescription.BorderStyle = BorderStyle.None;
			richTextBoxDescription.Location = new Point(95,42);
			richTextBoxDescription.Name = "richTextBoxDescription";
			richTextBoxDescription.Size = new Size(471,53);
			richTextBoxDescription.TabIndex = 39;
			richTextBoxDescription.TabStop = false;
			richTextBoxDescription.Text = "";
			// 
			// panel2
			// 
			panel2.Controls.Add(checkBox_Inbound);
			panel2.Controls.Add(checkBox_Outbound);
			panel2.Location = new Point(412,150);
			panel2.Name = "panel2";
			panel2.Size = new Size(152,30);
			panel2.TabIndex = 38;
			// 
			// checkBox_Inbound
			// 
			checkBox_Inbound.AutoSize = true;
			checkBox_Inbound.Location = new Point(3,6);
			checkBox_Inbound.Name = "checkBox_Inbound";
			checkBox_Inbound.Size = new Size(50,19);
			checkBox_Inbound.TabIndex = 4;
			checkBox_Inbound.TabStop = false;
			checkBox_Inbound.Text = "連入";
			checkBox_Inbound.UseVisualStyleBackColor = true;
			checkBox_Inbound.CheckedChanged += Inandout;
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
			// panel1
			// 
			panel1.Controls.Add(checkBox_allow);
			panel1.Controls.Add(checkBox_block);
			panel1.Location = new Point(98,149);
			panel1.Name = "panel1";
			panel1.Size = new Size(152,30);
			panel1.TabIndex = 37;
			// 
			// checkBox_allow
			// 
			checkBox_allow.AutoSize = true;
			checkBox_allow.Location = new Point(3,5);
			checkBox_allow.Name = "checkBox_allow";
			checkBox_allow.Size = new Size(50,19);
			checkBox_allow.TabIndex = 3;
			checkBox_allow.TabStop = false;
			checkBox_allow.Text = "允許";
			checkBox_allow.UseVisualStyleBackColor = true;
			checkBox_allow.CheckedChanged += allowblock;
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
			// labelpath
			// 
			labelpath.AutoSize = true;
			labelpath.Location = new Point(18,116);
			labelpath.Name = "labelpath";
			labelpath.Size = new Size(55,15);
			labelpath.TabIndex = 36;
			labelpath.Text = "應用程式";
			// 
			// textBoxname
			// 
			textBoxname.Location = new Point(95,13);
			textBoxname.Name = "textBoxname";
			textBoxname.Size = new Size(471,23);
			textBoxname.TabIndex = 35;
			textBoxname.TabStop = false;
			// 
			// buttonOK
			// 
			buttonOK.Location = new Point(491,324);
			buttonOK.Name = "buttonOK";
			buttonOK.Size = new Size(75,23);
			buttonOK.TabIndex = 34;
			buttonOK.TabStop = false;
			buttonOK.Text = "確定";
			buttonOK.UseVisualStyleBackColor = true;
			buttonOK.Click += buttonOK_Click;
			// 
			// button_Browse
			// 
			button_Browse.Location = new Point(491,111);
			button_Browse.Name = "button_Browse";
			button_Browse.Size = new Size(75,23);
			button_Browse.TabIndex = 33;
			button_Browse.TabStop = false;
			button_Browse.Text = "瀏覽檔案...";
			button_Browse.UseVisualStyleBackColor = true;
			button_Browse.Click += button_Browse_Click;
			// 
			// textBox_path
			// 
			textBox_path.Location = new Point(95,112);
			textBox_path.Name = "textBox_path";
			textBox_path.PlaceholderText = "請選檔案...";
			textBox_path.ReadOnly = true;
			textBox_path.Size = new Size(390,23);
			textBox_path.TabIndex = 32;
			textBox_path.TabStop = false;
			// 
			// label_name
			// 
			label_name.AutoSize = true;
			label_name.Location = new Point(18,16);
			label_name.Name = "label_name";
			label_name.Size = new Size(31,15);
			label_name.TabIndex = 31;
			label_name.Text = "名稱";
			// 
			// openFileDialog1
			// 
			openFileDialog1.Filter = "Executable (*.exe)|*.exe|All files (*.*)|*.*";
			// 
			// labeloldname
			// 
			labeloldname.AutoSize = true;
			labeloldname.Location = new Point(95,294);
			labeloldname.Name = "labeloldname";
			labeloldname.Size = new Size(16,15);
			labeloldname.TabIndex = 55;
			labeloldname.Text = "...";
			labeloldname.Visible = false;
			// 
			// EditRuleForm
			// 
			AutoScaleDimensions = new SizeF(7F,15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(584,361);
			Controls.Add(labeloldname);
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
			Name = "EditRuleForm";
			ShowIcon = false;
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Edit Firewall Rule";
			Load += EditRuleForm_Load;
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBoxRemotePorts;
		private Label labelRemotePorts;
		private TextBox textBoxRemoteAddresses;
		private Label labelRemoteAddresses;
		private Label labelLocalPorts;
		private TextBox textBoxLocalPorts;
		private TextBox textBoxLocalAddresses;
		private Label labelLocalAddresses;
		private ComboBox comboBoxProtocol;
		private Label labelProtocol;
		private Panel panel3;
		private CheckBox checkBoxDomain;
		private CheckBox checkBoxPublic;
		private CheckBox checkBoxPrivate;
		private Label labelProfile;
		private Label labelcat;
		private Label labelAction;
		private Label labelDescription;
		private RichTextBox richTextBoxDescription;
		private Panel panel2;
		private CheckBox checkBox_Inbound;
		private CheckBox checkBox_Outbound;
		private Panel panel1;
		private CheckBox checkBox_allow;
		private CheckBox checkBox_block;
		private Label labelpath;
		private TextBox textBoxname;
		private Button buttonOK;
		private Button button_Browse;
		private TextBox textBox_path;
		public Label label_name;
		private OpenFileDialog openFileDialog1;
		private Label labeloldname;
	}
}