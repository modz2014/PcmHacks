namespace PcmHacking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.interfaceBox = new System.Windows.Forms.GroupBox();
            this.reinitializeButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.deviceDescription = new System.Windows.Forms.Label();
            this.operationsBox = new System.Windows.Forms.GroupBox();
            this.testWriteButton = new System.Windows.Forms.Button();
            this.exitKernelButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.writeCalibrationButton = new System.Windows.Forms.Button();
            this.readPropertiesButton = new System.Windows.Forms.Button();
            this.tabs = new System.Windows.Forms.TabControl();
            this.resultsTab = new System.Windows.Forms.TabPage();
            this.userLog = new System.Windows.Forms.TextBox();
            this.helpTab = new System.Windows.Forms.TabPage();
            this.helpWebBrowser = new System.Windows.Forms.WebBrowser();
            this.creditsTab = new System.Windows.Forms.TabPage();
            this.creditsWebBrowser = new System.Windows.Forms.WebBrowser();
            this.debugTab = new System.Windows.Forms.TabPage();
            this.debugLog = new System.Windows.Forms.TextBox();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.menuItemTools = new System.Windows.Forms.ToolStripMenuItem();
            this.readEntirePCMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verifyEntirePCMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyVINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeParmetersCloneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeOSCalibrationBootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeFullToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEnable4xReadWrite = new System.Windows.Forms.ToolStripMenuItem();
            this.operation = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.interfaceBox.SuspendLayout();
            this.operationsBox.SuspendLayout();
            this.tabs.SuspendLayout();
            this.resultsTab.SuspendLayout();
            this.helpTab.SuspendLayout();
            this.creditsTab.SuspendLayout();
            this.debugTab.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // interfaceBox
            // 
            this.interfaceBox.Controls.Add(this.reinitializeButton);
            this.interfaceBox.Controls.Add(this.selectButton);
            this.interfaceBox.Controls.Add(this.deviceDescription);
            this.interfaceBox.Location = new System.Drawing.Point(12, 32);
            this.interfaceBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.interfaceBox.Name = "interfaceBox";
            this.interfaceBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.interfaceBox.Size = new System.Drawing.Size(299, 114);
            this.interfaceBox.TabIndex = 0;
            this.interfaceBox.TabStop = false;
            this.interfaceBox.Text = "Device";
            // 
            // reinitializeButton
            // 
            this.reinitializeButton.Location = new System.Drawing.Point(5, 76);
            this.reinitializeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reinitializeButton.Name = "reinitializeButton";
            this.reinitializeButton.Size = new System.Drawing.Size(288, 31);
            this.reinitializeButton.TabIndex = 2;
            this.reinitializeButton.Text = "Re-&Initialize Device";
            this.reinitializeButton.UseVisualStyleBackColor = true;
            this.reinitializeButton.Click += new System.EventHandler(this.reinitializeButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(5, 39);
            this.selectButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(288, 31);
            this.selectButton.TabIndex = 1;
            this.selectButton.Text = "&Select Device";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // deviceDescription
            // 
            this.deviceDescription.Location = new System.Drawing.Point(5, 20);
            this.deviceDescription.Name = "deviceDescription";
            this.deviceDescription.Size = new System.Drawing.Size(285, 16);
            this.deviceDescription.TabIndex = 0;
            this.deviceDescription.Text = "Device name will be displayed here";
            // 
            // operationsBox
            // 
            this.operationsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.operationsBox.Controls.Add(this.testWriteButton);
            this.operationsBox.Controls.Add(this.exitKernelButton);
            this.operationsBox.Controls.Add(this.cancelButton);
            this.operationsBox.Controls.Add(this.writeCalibrationButton);
            this.operationsBox.Controls.Add(this.readPropertiesButton);
            this.operationsBox.Location = new System.Drawing.Point(12, 191);
            this.operationsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.operationsBox.Name = "operationsBox";
            this.operationsBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.operationsBox.Size = new System.Drawing.Size(299, 427);
            this.operationsBox.TabIndex = 1;
            this.operationsBox.TabStop = false;
            this.operationsBox.Text = "Operations";
            // 
            // testWriteButton
            // 
            this.testWriteButton.Location = new System.Drawing.Point(5, 58);
            this.testWriteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testWriteButton.Name = "testWriteButton";
            this.testWriteButton.Size = new System.Drawing.Size(288, 31);
            this.testWriteButton.TabIndex = 4;
            this.testWriteButton.Text = "T&est Write";
            this.testWriteButton.UseVisualStyleBackColor = true;
            this.testWriteButton.Click += new System.EventHandler(this.testWriteButton_Click);
            // 
            // exitKernelButton
            // 
            this.exitKernelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exitKernelButton.Location = new System.Drawing.Point(5, 345);
            this.exitKernelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitKernelButton.Name = "exitKernelButton";
            this.exitKernelButton.Size = new System.Drawing.Size(288, 31);
            this.exitKernelButton.TabIndex = 9;
            this.exitKernelButton.Text = "&Halt Kernel";
            this.exitKernelButton.UseVisualStyleBackColor = true;
            this.exitKernelButton.Click += new System.EventHandler(this.testKernelButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.Location = new System.Drawing.Point(5, 386);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(288, 31);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // writeCalibrationButton
            // 
            this.writeCalibrationButton.Location = new System.Drawing.Point(5, 94);
            this.writeCalibrationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.writeCalibrationButton.Name = "writeCalibrationButton";
            this.writeCalibrationButton.Size = new System.Drawing.Size(288, 31);
            this.writeCalibrationButton.TabIndex = 5;
            this.writeCalibrationButton.Text = "&Write Calibration";
            this.writeCalibrationButton.UseVisualStyleBackColor = true;
            this.writeCalibrationButton.Click += new System.EventHandler(this.writeCalibrationButton_Click);
            // 
            // readPropertiesButton
            // 
            this.readPropertiesButton.Location = new System.Drawing.Point(5, 22);
            this.readPropertiesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.readPropertiesButton.Name = "readPropertiesButton";
            this.readPropertiesButton.Size = new System.Drawing.Size(288, 31);
            this.readPropertiesButton.TabIndex = 0;
            this.readPropertiesButton.Text = "Read &Properties";
            this.readPropertiesButton.UseVisualStyleBackColor = true;
            this.readPropertiesButton.Click += new System.EventHandler(this.readPropertiesButton_Click);
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.resultsTab);
            this.tabs.Controls.Add(this.helpTab);
            this.tabs.Controls.Add(this.creditsTab);
            this.tabs.Controls.Add(this.debugTab);
            this.tabs.Location = new System.Drawing.Point(317, 108);
            this.tabs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(811, 510);
            this.tabs.TabIndex = 2;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
            // 
            // resultsTab
            // 
            this.resultsTab.Controls.Add(this.userLog);
            this.resultsTab.Location = new System.Drawing.Point(4, 25);
            this.resultsTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultsTab.Name = "resultsTab";
            this.resultsTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultsTab.Size = new System.Drawing.Size(803, 481);
            this.resultsTab.TabIndex = 0;
            this.resultsTab.Text = "Results";
            this.resultsTab.UseVisualStyleBackColor = true;
            // 
            // userLog
            // 
            this.userLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userLog.Location = new System.Drawing.Point(5, 6);
            this.userLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userLog.Multiline = true;
            this.userLog.Name = "userLog";
            this.userLog.ReadOnly = true;
            this.userLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.userLog.Size = new System.Drawing.Size(791, 466);
            this.userLog.TabIndex = 0;
            // 
            // helpTab
            // 
            this.helpTab.Controls.Add(this.helpWebBrowser);
            this.helpTab.Location = new System.Drawing.Point(4, 25);
            this.helpTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.helpTab.Name = "helpTab";
            this.helpTab.Size = new System.Drawing.Size(803, 557);
            this.helpTab.TabIndex = 2;
            this.helpTab.Text = "Help";
            this.helpTab.UseVisualStyleBackColor = true;
            // 
            // helpWebBrowser
            // 
            this.helpWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.helpWebBrowser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.helpWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.helpWebBrowser.Name = "helpWebBrowser";
            this.helpWebBrowser.Size = new System.Drawing.Size(803, 557);
            this.helpWebBrowser.TabIndex = 0;
            // 
            // creditsTab
            // 
            this.creditsTab.Controls.Add(this.creditsWebBrowser);
            this.creditsTab.Location = new System.Drawing.Point(4, 25);
            this.creditsTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.creditsTab.Name = "creditsTab";
            this.creditsTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.creditsTab.Size = new System.Drawing.Size(803, 557);
            this.creditsTab.TabIndex = 3;
            this.creditsTab.Text = "Credits";
            this.creditsTab.UseVisualStyleBackColor = true;
            // 
            // creditsWebBrowser
            // 
            this.creditsWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.creditsWebBrowser.Location = new System.Drawing.Point(4, 4);
            this.creditsWebBrowser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.creditsWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.creditsWebBrowser.Name = "creditsWebBrowser";
            this.creditsWebBrowser.Size = new System.Drawing.Size(795, 549);
            this.creditsWebBrowser.TabIndex = 1;
            // 
            // debugTab
            // 
            this.debugTab.Controls.Add(this.debugLog);
            this.debugTab.Location = new System.Drawing.Point(4, 25);
            this.debugTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.debugTab.Name = "debugTab";
            this.debugTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.debugTab.Size = new System.Drawing.Size(803, 557);
            this.debugTab.TabIndex = 1;
            this.debugTab.Text = "Debug Log";
            this.debugTab.UseVisualStyleBackColor = true;
            // 
            // debugLog
            // 
            this.debugLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debugLog.Location = new System.Drawing.Point(3, 2);
            this.debugLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.debugLog.Multiline = true;
            this.debugLog.Name = "debugLog";
            this.debugLog.ReadOnly = true;
            this.debugLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.debugLog.Size = new System.Drawing.Size(797, 553);
            this.debugLog.TabIndex = 0;
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemTools,
            this.menuItemOptions});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(1139, 28);
            this.menuStripMain.TabIndex = 3;
            this.menuStripMain.Text = "Main Menu";
            // 
            // menuItemTools
            // 
            this.menuItemTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readEntirePCMToolStripMenuItem,
            this.verifyEntirePCMToolStripMenuItem,
            this.modifyVINToolStripMenuItem,
            this.writeParmetersCloneToolStripMenuItem,
            this.writeOSCalibrationBootToolStripMenuItem,
            this.writeFullToolStripMenuItem});
            this.menuItemTools.Name = "menuItemTools";
            this.menuItemTools.Size = new System.Drawing.Size(56, 24);
            this.menuItemTools.Text = "&Tools";
            // 
            // readEntirePCMToolStripMenuItem
            // 
            this.readEntirePCMToolStripMenuItem.Name = "readEntirePCMToolStripMenuItem";
            this.readEntirePCMToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.readEntirePCMToolStripMenuItem.Text = "&Read Entire PCM";
            this.readEntirePCMToolStripMenuItem.Click += new System.EventHandler(this.readFullContentsButton_Click);
            // 
            // verifyEntirePCMToolStripMenuItem
            // 
            this.verifyEntirePCMToolStripMenuItem.Name = "verifyEntirePCMToolStripMenuItem";
            this.verifyEntirePCMToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.verifyEntirePCMToolStripMenuItem.Text = "&Verify Entire PCM";
            this.verifyEntirePCMToolStripMenuItem.Click += new System.EventHandler(this.quickComparisonButton_Click);
            // 
            // modifyVINToolStripMenuItem
            // 
            this.modifyVINToolStripMenuItem.Name = "modifyVINToolStripMenuItem";
            this.modifyVINToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.modifyVINToolStripMenuItem.Text = "&Change VIN";
            this.modifyVINToolStripMenuItem.Click += new System.EventHandler(this.modifyVinButton_Click);
            // 
            // writeParmetersCloneToolStripMenuItem
            // 
            this.writeParmetersCloneToolStripMenuItem.Name = "writeParmetersCloneToolStripMenuItem";
            this.writeParmetersCloneToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.writeParmetersCloneToolStripMenuItem.Text = "Write &Parameters";
            this.writeParmetersCloneToolStripMenuItem.Click += new System.EventHandler(this.writeParametersButton_Click);
            // 
            // writeOSCalibrationBootToolStripMenuItem
            // 
            this.writeOSCalibrationBootToolStripMenuItem.Name = "writeOSCalibrationBootToolStripMenuItem";
            this.writeOSCalibrationBootToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.writeOSCalibrationBootToolStripMenuItem.Text = "Write &OS, Calibration && Boot";
            this.writeOSCalibrationBootToolStripMenuItem.Click += new System.EventHandler(this.writeOSCalibrationBootToolStripMenuItem_Click);
            // 
            // writeFullToolStripMenuItem
            // 
            this.writeFullToolStripMenuItem.Name = "writeFullToolStripMenuItem";
            this.writeFullToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.writeFullToolStripMenuItem.Text = "Write &Full Flash (Clone)";
            this.writeFullToolStripMenuItem.Click += new System.EventHandler(this.writeFullToolStripMenuItem_Click);
            // 
            // menuItemOptions
            // 
            this.menuItemOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemEnable4xReadWrite});
            this.menuItemOptions.Name = "menuItemOptions";
            this.menuItemOptions.Size = new System.Drawing.Size(73, 24);
            this.menuItemOptions.Text = "&Options";
            // 
            // menuItemEnable4xReadWrite
            // 
            this.menuItemEnable4xReadWrite.Name = "menuItemEnable4xReadWrite";
            this.menuItemEnable4xReadWrite.Size = new System.Drawing.Size(257, 26);
            this.menuItemEnable4xReadWrite.Text = "Enable &4x Communication";
            this.menuItemEnable4xReadWrite.Click += new System.EventHandler(this.enable4xReadWrite_Click);
            // 
            // operation
            // 
            this.operation.Location = new System.Drawing.Point(318, 42);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(285, 16);
            this.operation.TabIndex = 3;
            this.operation.Text = "Current operation will be displayed here.";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(321, 71);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(803, 23);
            this.progressBar.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AcceptButton = this.readPropertiesButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 631);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.operation);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.operationsBox);
            this.Controls.Add(this.interfaceBox);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "PCM Hammer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.interfaceBox.ResumeLayout(false);
            this.operationsBox.ResumeLayout(false);
            this.tabs.ResumeLayout(false);
            this.resultsTab.ResumeLayout(false);
            this.resultsTab.PerformLayout();
            this.helpTab.ResumeLayout(false);
            this.creditsTab.ResumeLayout(false);
            this.debugTab.ResumeLayout(false);
            this.debugTab.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox interfaceBox;
        private System.Windows.Forms.GroupBox operationsBox;
        private System.Windows.Forms.Button writeCalibrationButton;
        private System.Windows.Forms.Button readPropertiesButton;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage resultsTab;
        private System.Windows.Forms.TextBox userLog;
        private System.Windows.Forms.TabPage debugTab;
        private System.Windows.Forms.TextBox debugLog;
        private System.Windows.Forms.Button reinitializeButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Label deviceDescription;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TabPage helpTab;
        private System.Windows.Forms.WebBrowser helpWebBrowser;
        private System.Windows.Forms.Button exitKernelButton;
        private System.Windows.Forms.Button testWriteButton;
        private System.Windows.Forms.TabPage creditsTab;
        private System.Windows.Forms.WebBrowser creditsWebBrowser;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem menuItemOptions;
        private System.Windows.Forms.ToolStripMenuItem menuItemEnable4xReadWrite;
        private System.Windows.Forms.ToolStripMenuItem menuItemTools;
        private System.Windows.Forms.ToolStripMenuItem readEntirePCMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verifyEntirePCMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyVINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeParmetersCloneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeOSCalibrationBootToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeFullToolStripMenuItem;
        private System.Windows.Forms.Label operation;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

