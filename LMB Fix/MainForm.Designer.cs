namespace LMB_Fix
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.leftButtonFixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightButtonFixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsGroup = new System.Windows.Forms.GroupBox();
            this.runAtStartCheckBox = new System.Windows.Forms.CheckBox();
            this.rightButtonLabel = new System.Windows.Forms.Label();
            this.leftButtonLabel = new System.Windows.Forms.Label();
            this.rightButtonTrackBar = new System.Windows.Forms.TrackBar();
            this.leftButtonTrackBar = new System.Windows.Forms.TrackBar();
            this.rightButtonFixCheckBox = new System.Windows.Forms.CheckBox();
            this.leftButtonFixCheckBox = new System.Windows.Forms.CheckBox();
            this.historyGroup = new System.Windows.Forms.GroupBox();
            this.historyRichTextBox = new System.Windows.Forms.RichTextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.notifyIconMenu.SuspendLayout();
            this.settingsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightButtonTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftButtonTrackBar)).BeginInit();
            this.historyGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipTitle = "Status";
            this.notifyIcon.ContextMenuStrip = this.notifyIconMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "LMB Fix";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // notifyIconMenu
            // 
            this.notifyIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.toolStripSeparator1,
            this.leftButtonFixToolStripMenuItem,
            this.rightButtonFixToolStripMenuItem,
            this.toolStripSeparator2,
            this.aboutToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.notifyIconMenu.Name = "notifyIconMenu";
            this.notifyIconMenu.Size = new System.Drawing.Size(157, 132);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showToolStripMenuItem.Text = "Show...";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // leftButtonFixToolStripMenuItem
            // 
            this.leftButtonFixToolStripMenuItem.Name = "leftButtonFixToolStripMenuItem";
            this.leftButtonFixToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.leftButtonFixToolStripMenuItem.Text = "Left button fix";
            this.leftButtonFixToolStripMenuItem.Click += new System.EventHandler(this.leftButtonFixToolStripMenuItem_Click);
            // 
            // rightButtonFixToolStripMenuItem
            // 
            this.rightButtonFixToolStripMenuItem.Name = "rightButtonFixToolStripMenuItem";
            this.rightButtonFixToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rightButtonFixToolStripMenuItem.Text = "Right button fix";
            this.rightButtonFixToolStripMenuItem.Click += new System.EventHandler(this.rightButtonFixToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // settingsGroup
            // 
            this.settingsGroup.Controls.Add(this.runAtStartCheckBox);
            this.settingsGroup.Controls.Add(this.rightButtonLabel);
            this.settingsGroup.Controls.Add(this.leftButtonLabel);
            this.settingsGroup.Controls.Add(this.rightButtonTrackBar);
            this.settingsGroup.Controls.Add(this.leftButtonTrackBar);
            this.settingsGroup.Controls.Add(this.rightButtonFixCheckBox);
            this.settingsGroup.Controls.Add(this.leftButtonFixCheckBox);
            this.settingsGroup.Location = new System.Drawing.Point(12, 12);
            this.settingsGroup.Name = "settingsGroup";
            this.settingsGroup.Size = new System.Drawing.Size(274, 116);
            this.settingsGroup.TabIndex = 0;
            this.settingsGroup.TabStop = false;
            this.settingsGroup.Text = "Settings";
            // 
            // runAtStartCheckBox
            // 
            this.runAtStartCheckBox.AutoSize = true;
            this.runAtStartCheckBox.Location = new System.Drawing.Point(11, 92);
            this.runAtStartCheckBox.Name = "runAtStartCheckBox";
            this.runAtStartCheckBox.Size = new System.Drawing.Size(118, 17);
            this.runAtStartCheckBox.TabIndex = 6;
            this.runAtStartCheckBox.Text = "Run with windows?";
            this.runAtStartCheckBox.UseVisualStyleBackColor = true;
            this.runAtStartCheckBox.CheckedChanged += new System.EventHandler(this.runAtStartCheckBox_CheckedChanged);
            // 
            // rightButtonLabel
            // 
            this.rightButtonLabel.AutoSize = true;
            this.rightButtonLabel.Location = new System.Drawing.Point(225, 63);
            this.rightButtonLabel.Name = "rightButtonLabel";
            this.rightButtonLabel.Size = new System.Drawing.Size(26, 13);
            this.rightButtonLabel.TabIndex = 5;
            this.rightButtonLabel.Text = "0ms";
            // 
            // leftButtonLabel
            // 
            this.leftButtonLabel.AutoSize = true;
            this.leftButtonLabel.Location = new System.Drawing.Point(225, 33);
            this.leftButtonLabel.Name = "leftButtonLabel";
            this.leftButtonLabel.Size = new System.Drawing.Size(26, 13);
            this.leftButtonLabel.TabIndex = 4;
            this.leftButtonLabel.Text = "0ms";
            // 
            // rightButtonTrackBar
            // 
            this.rightButtonTrackBar.Enabled = false;
            this.rightButtonTrackBar.LargeChange = 20;
            this.rightButtonTrackBar.Location = new System.Drawing.Point(107, 54);
            this.rightButtonTrackBar.Maximum = 200;
            this.rightButtonTrackBar.Minimum = 5;
            this.rightButtonTrackBar.Name = "rightButtonTrackBar";
            this.rightButtonTrackBar.Size = new System.Drawing.Size(112, 45);
            this.rightButtonTrackBar.TabIndex = 3;
            this.rightButtonTrackBar.Value = 5;
            this.rightButtonTrackBar.ValueChanged += new System.EventHandler(this.rightButtonTrackBar_ValueChanged);
            // 
            // leftButtonTrackBar
            // 
            this.leftButtonTrackBar.Enabled = false;
            this.leftButtonTrackBar.LargeChange = 20;
            this.leftButtonTrackBar.Location = new System.Drawing.Point(107, 19);
            this.leftButtonTrackBar.Maximum = 200;
            this.leftButtonTrackBar.Minimum = 5;
            this.leftButtonTrackBar.Name = "leftButtonTrackBar";
            this.leftButtonTrackBar.Size = new System.Drawing.Size(112, 45);
            this.leftButtonTrackBar.TabIndex = 2;
            this.leftButtonTrackBar.Value = 5;
            this.leftButtonTrackBar.ValueChanged += new System.EventHandler(this.leftButtonTrackBar_ValueChanged);
            // 
            // rightButtonFixCheckBox
            // 
            this.rightButtonFixCheckBox.AutoSize = true;
            this.rightButtonFixCheckBox.Location = new System.Drawing.Point(11, 59);
            this.rightButtonFixCheckBox.Name = "rightButtonFixCheckBox";
            this.rightButtonFixCheckBox.Size = new System.Drawing.Size(97, 17);
            this.rightButtonFixCheckBox.TabIndex = 1;
            this.rightButtonFixCheckBox.Text = "Right button fix";
            this.rightButtonFixCheckBox.UseVisualStyleBackColor = true;
            this.rightButtonFixCheckBox.CheckedChanged += new System.EventHandler(this.rightButtonFixCheckBox_CheckedChanged);
            // 
            // leftButtonFixCheckBox
            // 
            this.leftButtonFixCheckBox.AutoSize = true;
            this.leftButtonFixCheckBox.Location = new System.Drawing.Point(11, 33);
            this.leftButtonFixCheckBox.Name = "leftButtonFixCheckBox";
            this.leftButtonFixCheckBox.Size = new System.Drawing.Size(90, 17);
            this.leftButtonFixCheckBox.TabIndex = 0;
            this.leftButtonFixCheckBox.Text = "Left button fix";
            this.leftButtonFixCheckBox.UseVisualStyleBackColor = true;
            this.leftButtonFixCheckBox.CheckedChanged += new System.EventHandler(this.leftButtonFixCheckBox_CheckedChanged);
            // 
            // historyGroup
            // 
            this.historyGroup.Controls.Add(this.historyRichTextBox);
            this.historyGroup.Location = new System.Drawing.Point(292, 12);
            this.historyGroup.Name = "historyGroup";
            this.historyGroup.Size = new System.Drawing.Size(274, 116);
            this.historyGroup.TabIndex = 1;
            this.historyGroup.TabStop = false;
            this.historyGroup.Text = "History";
            // 
            // historyRichTextBox
            // 
            this.historyRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyRichTextBox.Location = new System.Drawing.Point(3, 16);
            this.historyRichTextBox.Name = "historyRichTextBox";
            this.historyRichTextBox.Size = new System.Drawing.Size(268, 97);
            this.historyRichTextBox.TabIndex = 0;
            this.historyRichTextBox.Text = "";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(248, 134);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(329, 134);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(491, 134);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(410, 134);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(75, 23);
            this.aboutButton.TabIndex = 5;
            this.aboutButton.Text = "About...";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 161);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.historyGroup);
            this.Controls.Add(this.settingsGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "LMB Fix";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.notifyIconMenu.ResumeLayout(false);
            this.settingsGroup.ResumeLayout(false);
            this.settingsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightButtonTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftButtonTrackBar)).EndInit();
            this.historyGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.GroupBox settingsGroup;
        private System.Windows.Forms.Label rightButtonLabel;
        private System.Windows.Forms.Label leftButtonLabel;
        private System.Windows.Forms.TrackBar rightButtonTrackBar;
        private System.Windows.Forms.TrackBar leftButtonTrackBar;
        private System.Windows.Forms.CheckBox rightButtonFixCheckBox;
        private System.Windows.Forms.CheckBox leftButtonFixCheckBox;
        private System.Windows.Forms.GroupBox historyGroup;
        private System.Windows.Forms.RichTextBox historyRichTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.CheckBox runAtStartCheckBox;
        private System.Windows.Forms.ContextMenuStrip notifyIconMenu;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem leftButtonFixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightButtonFixToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}