﻿namespace SABSync
{
    partial class FrmOptions
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
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("General");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("SABnzbd");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("TV Shows");
            this.treeViewOptions = new System.Windows.Forms.TreeView();
            this.panelSab = new System.Windows.Forms.Panel();
            this.btnTestSab = new System.Windows.Forms.Button();
            this.chkReplaceChars = new System.Windows.Forms.CheckBox();
            this.btnPriorityHigh = new System.Windows.Forms.Button();
            this.btnPriorityNormal = new System.Windows.Forms.Button();
            this.btnPriorityLow = new System.Windows.Forms.Button();
            this.txtPriority = new System.Windows.Forms.TextBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.txtTvTemplate = new System.Windows.Forms.TextBox();
            this.lblTvTemplate = new System.Windows.Forms.Label();
            this.txtTvDailyTemplate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNzbDir = new System.Windows.Forms.TextBox();
            this.lblNzbDir = new System.Windows.Forms.Label();
            this.nzbDirBrowse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSabInfoPort = new System.Windows.Forms.TextBox();
            this.lblSabInfoPort = new System.Windows.Forms.Label();
            this.lblApiKey = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtApiKey = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblSabInfoHost = new System.Windows.Forms.Label();
            this.txtSabInfoHost = new System.Windows.Forms.TextBox();
            this.panelShows = new System.Windows.Forms.Panel();
            this.comboBoxDefaultQuality = new System.Windows.Forms.ComboBox();
            this.chkDownloadPropers = new System.Windows.Forms.CheckBox();
            this.lblDownloadQuality = new System.Windows.Forms.Label();
            this.txtVideoExt = new System.Windows.Forms.TextBox();
            this.lblVideoExt = new System.Windows.Forms.Label();
            this.btnTvRootClear = new System.Windows.Forms.Button();
            this.txtTvRoot = new System.Windows.Forms.TextBox();
            this.lblTvRoot = new System.Windows.Forms.Label();
            this.tvRootBrowse = new System.Windows.Forms.Button();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.chkSyncOnStart = new System.Windows.Forms.CheckBox();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.numMinutes = new System.Windows.Forms.NumericUpDown();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btn120Days = new System.Windows.Forms.Button();
            this.btn60Days = new System.Windows.Forms.Button();
            this.btn30Days = new System.Windows.Forms.Button();
            this.txtDeleteLogs = new System.Windows.Forms.TextBox();
            this.lblDeleteLogs = new System.Windows.Forms.Label();
            this.chkVerboseLogging = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.tvRootDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.nzbDirDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.labelOptionsSab_test = new System.Windows.Forms.Label();
            this.panelSab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelShows.SuspendLayout();
            this.panelGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // treeViewOptions
            // 
            this.treeViewOptions.Location = new System.Drawing.Point(13, 13);
            this.treeViewOptions.Name = "treeViewOptions";
            treeNode7.Name = "NodeGeneral";
            treeNode7.Text = "General";
            treeNode8.Name = "NodeSab";
            treeNode8.Text = "SABnzbd";
            treeNode9.Name = "NodeShows";
            treeNode9.Text = "TV Shows";
            this.treeViewOptions.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9});
            this.treeViewOptions.Size = new System.Drawing.Size(121, 347);
            this.treeViewOptions.TabIndex = 0;
            this.treeViewOptions.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewOptions_AfterSelect);
            // 
            // panelSab
            // 
            this.panelSab.Controls.Add(this.labelOptionsSab_test);
            this.panelSab.Controls.Add(this.btnTestSab);
            this.panelSab.Controls.Add(this.chkReplaceChars);
            this.panelSab.Controls.Add(this.btnPriorityHigh);
            this.panelSab.Controls.Add(this.btnPriorityNormal);
            this.panelSab.Controls.Add(this.btnPriorityLow);
            this.panelSab.Controls.Add(this.txtPriority);
            this.panelSab.Controls.Add(this.lblPriority);
            this.panelSab.Controls.Add(this.txtTvTemplate);
            this.panelSab.Controls.Add(this.lblTvTemplate);
            this.panelSab.Controls.Add(this.txtTvDailyTemplate);
            this.panelSab.Controls.Add(this.label1);
            this.panelSab.Controls.Add(this.txtNzbDir);
            this.panelSab.Controls.Add(this.lblNzbDir);
            this.panelSab.Controls.Add(this.nzbDirBrowse);
            this.panelSab.Controls.Add(this.groupBox1);
            this.panelSab.Location = new System.Drawing.Point(145, 13);
            this.panelSab.Name = "panelSab";
            this.panelSab.Size = new System.Drawing.Size(445, 322);
            this.panelSab.TabIndex = 1;
            this.panelSab.Visible = false;
            // 
            // btnTestSab
            // 
            this.btnTestSab.Location = new System.Drawing.Point(39, 286);
            this.btnTestSab.Name = "btnTestSab";
            this.btnTestSab.Size = new System.Drawing.Size(64, 23);
            this.btnTestSab.TabIndex = 50;
            this.btnTestSab.Text = "Test SAB";
            this.btnTestSab.UseVisualStyleBackColor = true;
            this.btnTestSab.Click += new System.EventHandler(this.btnTestSab_Click);
            // 
            // chkReplaceChars
            // 
            this.chkReplaceChars.AutoSize = true;
            this.chkReplaceChars.Location = new System.Drawing.Point(113, 264);
            this.chkReplaceChars.Name = "chkReplaceChars";
            this.chkReplaceChars.Size = new System.Drawing.Size(120, 17);
            this.chkReplaceChars.TabIndex = 49;
            this.chkReplaceChars.Text = "Replace Characters";
            this.chkReplaceChars.UseVisualStyleBackColor = true;
            // 
            // btnPriorityHigh
            // 
            this.btnPriorityHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPriorityHigh.Location = new System.Drawing.Point(322, 238);
            this.btnPriorityHigh.Name = "btnPriorityHigh";
            this.btnPriorityHigh.Size = new System.Drawing.Size(52, 20);
            this.btnPriorityHigh.TabIndex = 48;
            this.btnPriorityHigh.Text = "High";
            this.btnPriorityHigh.UseVisualStyleBackColor = true;
            this.btnPriorityHigh.Click += new System.EventHandler(this.btnPriorityHigh_Click);
            // 
            // btnPriorityNormal
            // 
            this.btnPriorityNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPriorityNormal.Location = new System.Drawing.Point(261, 238);
            this.btnPriorityNormal.Name = "btnPriorityNormal";
            this.btnPriorityNormal.Size = new System.Drawing.Size(52, 20);
            this.btnPriorityNormal.TabIndex = 47;
            this.btnPriorityNormal.Text = "Normal";
            this.btnPriorityNormal.UseVisualStyleBackColor = true;
            this.btnPriorityNormal.Click += new System.EventHandler(this.btnPriorityNormal_Click);
            // 
            // btnPriorityLow
            // 
            this.btnPriorityLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPriorityLow.Location = new System.Drawing.Point(200, 238);
            this.btnPriorityLow.Name = "btnPriorityLow";
            this.btnPriorityLow.Size = new System.Drawing.Size(52, 20);
            this.btnPriorityLow.TabIndex = 46;
            this.btnPriorityLow.Text = "Low";
            this.btnPriorityLow.UseVisualStyleBackColor = true;
            this.btnPriorityLow.Click += new System.EventHandler(this.btnPriorityLow_Click);
            // 
            // txtPriority
            // 
            this.txtPriority.BackColor = System.Drawing.SystemColors.Window;
            this.txtPriority.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriority.Location = new System.Drawing.Point(113, 237);
            this.txtPriority.Name = "txtPriority";
            this.txtPriority.Size = new System.Drawing.Size(77, 22);
            this.txtPriority.TabIndex = 44;
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(66, 244);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(41, 13);
            this.lblPriority.TabIndex = 45;
            this.lblPriority.Text = "Priority:";
            // 
            // txtTvTemplate
            // 
            this.txtTvTemplate.BackColor = System.Drawing.SystemColors.Window;
            this.txtTvTemplate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTvTemplate.Location = new System.Drawing.Point(113, 157);
            this.txtTvTemplate.Name = "txtTvTemplate";
            this.txtTvTemplate.Size = new System.Drawing.Size(309, 22);
            this.txtTvTemplate.TabIndex = 16;
            // 
            // lblTvTemplate
            // 
            this.lblTvTemplate.AutoSize = true;
            this.lblTvTemplate.Location = new System.Drawing.Point(39, 164);
            this.lblTvTemplate.Name = "lblTvTemplate";
            this.lblTvTemplate.Size = new System.Drawing.Size(71, 13);
            this.lblTvTemplate.TabIndex = 18;
            this.lblTvTemplate.Text = "TV Template:";
            // 
            // txtTvDailyTemplate
            // 
            this.txtTvDailyTemplate.BackColor = System.Drawing.SystemColors.Window;
            this.txtTvDailyTemplate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTvDailyTemplate.Location = new System.Drawing.Point(113, 183);
            this.txtTvDailyTemplate.Name = "txtTvDailyTemplate";
            this.txtTvDailyTemplate.Size = new System.Drawing.Size(309, 22);
            this.txtTvDailyTemplate.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "TV Daily Template:";
            // 
            // txtNzbDir
            // 
            this.txtNzbDir.BackColor = System.Drawing.SystemColors.Window;
            this.txtNzbDir.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNzbDir.Location = new System.Drawing.Point(113, 210);
            this.txtNzbDir.Name = "txtNzbDir";
            this.txtNzbDir.Size = new System.Drawing.Size(279, 22);
            this.txtNzbDir.TabIndex = 13;
            // 
            // lblNzbDir
            // 
            this.lblNzbDir.AutoSize = true;
            this.lblNzbDir.Location = new System.Drawing.Point(30, 217);
            this.lblNzbDir.Name = "lblNzbDir";
            this.lblNzbDir.Size = new System.Drawing.Size(77, 13);
            this.lblNzbDir.TabIndex = 14;
            this.lblNzbDir.Text = "NZB Directory:";
            // 
            // nzbDirBrowse
            // 
            this.nzbDirBrowse.Location = new System.Drawing.Point(398, 208);
            this.nzbDirBrowse.Name = "nzbDirBrowse";
            this.nzbDirBrowse.Size = new System.Drawing.Size(24, 23);
            this.nzbDirBrowse.TabIndex = 15;
            this.nzbDirBrowse.Text = "...";
            this.nzbDirBrowse.UseVisualStyleBackColor = true;
            this.nzbDirBrowse.Click += new System.EventHandler(this.nzbDirBrowse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSabInfoPort);
            this.groupBox1.Controls.Add(this.lblSabInfoPort);
            this.groupBox1.Controls.Add(this.lblApiKey);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.txtApiKey);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.lblUsername);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.lblSabInfoHost);
            this.groupBox1.Controls.Add(this.txtSabInfoHost);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 129);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SABnzbd Settings";
            // 
            // txtSabInfoPort
            // 
            this.txtSabInfoPort.BackColor = System.Drawing.SystemColors.Window;
            this.txtSabInfoPort.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSabInfoPort.Location = new System.Drawing.Point(359, 19);
            this.txtSabInfoPort.MaxLength = 5;
            this.txtSabInfoPort.Name = "txtSabInfoPort";
            this.txtSabInfoPort.Size = new System.Drawing.Size(51, 22);
            this.txtSabInfoPort.TabIndex = 6;
            // 
            // lblSabInfoPort
            // 
            this.lblSabInfoPort.AutoSize = true;
            this.lblSabInfoPort.Location = new System.Drawing.Point(324, 26);
            this.lblSabInfoPort.Name = "lblSabInfoPort";
            this.lblSabInfoPort.Size = new System.Drawing.Size(29, 13);
            this.lblSabInfoPort.TabIndex = 16;
            this.lblSabInfoPort.Text = "Port:";
            // 
            // lblApiKey
            // 
            this.lblApiKey.AutoSize = true;
            this.lblApiKey.Location = new System.Drawing.Point(50, 104);
            this.lblApiKey.Name = "lblApiKey";
            this.lblApiKey.Size = new System.Drawing.Size(48, 13);
            this.lblApiKey.TabIndex = 15;
            this.lblApiKey.Text = "API Key:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(42, 78);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Password:";
            // 
            // txtApiKey
            // 
            this.txtApiKey.BackColor = System.Drawing.SystemColors.Window;
            this.txtApiKey.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApiKey.Location = new System.Drawing.Point(104, 97);
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.Size = new System.Drawing.Size(306, 22);
            this.txtApiKey.TabIndex = 9;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(104, 71);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(306, 22);
            this.txtPassword.TabIndex = 8;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(40, 52);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 11;
            this.lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsername.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(104, 45);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(306, 22);
            this.txtUsername.TabIndex = 7;
            // 
            // lblSabInfoHost
            // 
            this.lblSabInfoHost.AutoSize = true;
            this.lblSabInfoHost.Location = new System.Drawing.Point(40, 26);
            this.lblSabInfoHost.Name = "lblSabInfoHost";
            this.lblSabInfoHost.Size = new System.Drawing.Size(58, 13);
            this.lblSabInfoHost.TabIndex = 9;
            this.lblSabInfoHost.Text = "Hostname:";
            // 
            // txtSabInfoHost
            // 
            this.txtSabInfoHost.BackColor = System.Drawing.SystemColors.Window;
            this.txtSabInfoHost.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSabInfoHost.Location = new System.Drawing.Point(104, 19);
            this.txtSabInfoHost.Name = "txtSabInfoHost";
            this.txtSabInfoHost.Size = new System.Drawing.Size(214, 22);
            this.txtSabInfoHost.TabIndex = 5;
            // 
            // panelShows
            // 
            this.panelShows.Controls.Add(this.comboBoxDefaultQuality);
            this.panelShows.Controls.Add(this.chkDownloadPropers);
            this.panelShows.Controls.Add(this.lblDownloadQuality);
            this.panelShows.Controls.Add(this.txtVideoExt);
            this.panelShows.Controls.Add(this.lblVideoExt);
            this.panelShows.Controls.Add(this.btnTvRootClear);
            this.panelShows.Controls.Add(this.txtTvRoot);
            this.panelShows.Controls.Add(this.lblTvRoot);
            this.panelShows.Controls.Add(this.tvRootBrowse);
            this.panelShows.Location = new System.Drawing.Point(42, 176);
            this.panelShows.Name = "panelShows";
            this.panelShows.Size = new System.Drawing.Size(48, 54);
            this.panelShows.TabIndex = 3;
            // 
            // comboBoxDefaultQuality
            // 
            this.comboBoxDefaultQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDefaultQuality.FormattingEnabled = true;
            this.comboBoxDefaultQuality.Items.AddRange(new object[] {
            "Best Possible",
            "xvid",
            "720p"});
            this.comboBoxDefaultQuality.Location = new System.Drawing.Point(103, 139);
            this.comboBoxDefaultQuality.Name = "comboBoxDefaultQuality";
            this.comboBoxDefaultQuality.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDefaultQuality.TabIndex = 55;
            // 
            // chkDownloadPropers
            // 
            this.chkDownloadPropers.AutoSize = true;
            this.chkDownloadPropers.Location = new System.Drawing.Point(103, 173);
            this.chkDownloadPropers.Name = "chkDownloadPropers";
            this.chkDownloadPropers.Size = new System.Drawing.Size(127, 17);
            this.chkDownloadPropers.TabIndex = 54;
            this.chkDownloadPropers.Text = "Download PROPERs";
            this.chkDownloadPropers.UseVisualStyleBackColor = true;
            // 
            // lblDownloadQuality
            // 
            this.lblDownloadQuality.AutoSize = true;
            this.lblDownloadQuality.Location = new System.Drawing.Point(21, 147);
            this.lblDownloadQuality.Name = "lblDownloadQuality";
            this.lblDownloadQuality.Size = new System.Drawing.Size(79, 13);
            this.lblDownloadQuality.TabIndex = 50;
            this.lblDownloadQuality.Text = "Default Quality:";
            // 
            // txtVideoExt
            // 
            this.txtVideoExt.BackColor = System.Drawing.SystemColors.Window;
            this.txtVideoExt.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVideoExt.Location = new System.Drawing.Point(103, 111);
            this.txtVideoExt.Name = "txtVideoExt";
            this.txtVideoExt.Size = new System.Drawing.Size(317, 22);
            this.txtVideoExt.TabIndex = 45;
            // 
            // lblVideoExt
            // 
            this.lblVideoExt.AutoSize = true;
            this.lblVideoExt.Location = new System.Drawing.Point(9, 118);
            this.lblVideoExt.Name = "lblVideoExt";
            this.lblVideoExt.Size = new System.Drawing.Size(91, 13);
            this.lblVideoExt.TabIndex = 46;
            this.lblVideoExt.Text = "Video Extensions:";
            // 
            // btnTvRootClear
            // 
            this.btnTvRootClear.Location = new System.Drawing.Point(336, 79);
            this.btnTvRootClear.Name = "btnTvRootClear";
            this.btnTvRootClear.Size = new System.Drawing.Size(54, 23);
            this.btnTvRootClear.TabIndex = 44;
            this.btnTvRootClear.Text = "Clear";
            this.btnTvRootClear.UseVisualStyleBackColor = true;
            this.btnTvRootClear.Click += new System.EventHandler(this.btnTvRootClear_Click);
            // 
            // txtTvRoot
            // 
            this.txtTvRoot.BackColor = System.Drawing.SystemColors.Window;
            this.txtTvRoot.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTvRoot.Location = new System.Drawing.Point(103, 82);
            this.txtTvRoot.Name = "txtTvRoot";
            this.txtTvRoot.Size = new System.Drawing.Size(227, 22);
            this.txtTvRoot.TabIndex = 41;
            // 
            // lblTvRoot
            // 
            this.lblTvRoot.AutoSize = true;
            this.lblTvRoot.Location = new System.Drawing.Point(50, 89);
            this.lblTvRoot.Name = "lblTvRoot";
            this.lblTvRoot.Size = new System.Drawing.Size(50, 13);
            this.lblTvRoot.TabIndex = 42;
            this.lblTvRoot.Text = "TV Root:";
            // 
            // tvRootBrowse
            // 
            this.tvRootBrowse.Location = new System.Drawing.Point(396, 79);
            this.tvRootBrowse.Name = "tvRootBrowse";
            this.tvRootBrowse.Size = new System.Drawing.Size(24, 23);
            this.tvRootBrowse.TabIndex = 43;
            this.tvRootBrowse.Text = "...";
            this.tvRootBrowse.UseVisualStyleBackColor = true;
            this.tvRootBrowse.Click += new System.EventHandler(this.tvRootBrowse_Click);
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.chkSyncOnStart);
            this.panelGeneral.Controls.Add(this.lblMinutes);
            this.panelGeneral.Controls.Add(this.numMinutes);
            this.panelGeneral.Controls.Add(this.lblTimer);
            this.panelGeneral.Controls.Add(this.btn120Days);
            this.panelGeneral.Controls.Add(this.btn60Days);
            this.panelGeneral.Controls.Add(this.btn30Days);
            this.panelGeneral.Controls.Add(this.txtDeleteLogs);
            this.panelGeneral.Controls.Add(this.lblDeleteLogs);
            this.panelGeneral.Controls.Add(this.chkVerboseLogging);
            this.panelGeneral.Location = new System.Drawing.Point(33, 94);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(57, 57);
            this.panelGeneral.TabIndex = 4;
            // 
            // chkSyncOnStart
            // 
            this.chkSyncOnStart.AutoSize = true;
            this.chkSyncOnStart.Location = new System.Drawing.Point(134, 119);
            this.chkSyncOnStart.Name = "chkSyncOnStart";
            this.chkSyncOnStart.Size = new System.Drawing.Size(92, 17);
            this.chkSyncOnStart.TabIndex = 58;
            this.chkSyncOnStart.Text = "Sync On Start";
            this.chkSyncOnStart.UseVisualStyleBackColor = true;
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(178, 96);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(44, 13);
            this.lblMinutes.TabIndex = 57;
            this.lblMinutes.Text = "Minutes";
            // 
            // numMinutes
            // 
            this.numMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMinutes.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numMinutes.Location = new System.Drawing.Point(126, 92);
            this.numMinutes.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.numMinutes.Name = "numMinutes";
            this.numMinutes.Size = new System.Drawing.Size(49, 20);
            this.numMinutes.TabIndex = 56;
            this.numMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numMinutes.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(58, 96);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(64, 13);
            this.lblTimer.TabIndex = 55;
            this.lblTimer.Text = "Sync Every:";
            // 
            // btn120Days
            // 
            this.btn120Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn120Days.Location = new System.Drawing.Point(211, 63);
            this.btn120Days.Margin = new System.Windows.Forms.Padding(0);
            this.btn120Days.Name = "btn120Days";
            this.btn120Days.Size = new System.Drawing.Size(29, 20);
            this.btn120Days.TabIndex = 54;
            this.btn120Days.Text = "120";
            this.btn120Days.UseVisualStyleBackColor = true;
            this.btn120Days.Click += new System.EventHandler(this.btn120Days_Click);
            // 
            // btn60Days
            // 
            this.btn60Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn60Days.Location = new System.Drawing.Point(186, 63);
            this.btn60Days.Margin = new System.Windows.Forms.Padding(0);
            this.btn60Days.Name = "btn60Days";
            this.btn60Days.Size = new System.Drawing.Size(23, 20);
            this.btn60Days.TabIndex = 53;
            this.btn60Days.Text = "60";
            this.btn60Days.UseVisualStyleBackColor = true;
            this.btn60Days.Click += new System.EventHandler(this.btn60Days_Click);
            // 
            // btn30Days
            // 
            this.btn30Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn30Days.Location = new System.Drawing.Point(161, 63);
            this.btn30Days.Margin = new System.Windows.Forms.Padding(0);
            this.btn30Days.Name = "btn30Days";
            this.btn30Days.Size = new System.Drawing.Size(23, 20);
            this.btn30Days.TabIndex = 52;
            this.btn30Days.Text = "30";
            this.btn30Days.UseVisualStyleBackColor = true;
            this.btn30Days.Click += new System.EventHandler(this.btn30Days_Click);
            // 
            // txtDeleteLogs
            // 
            this.txtDeleteLogs.BackColor = System.Drawing.SystemColors.Window;
            this.txtDeleteLogs.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeleteLogs.Location = new System.Drawing.Point(126, 62);
            this.txtDeleteLogs.MaxLength = 4;
            this.txtDeleteLogs.Name = "txtDeleteLogs";
            this.txtDeleteLogs.Size = new System.Drawing.Size(30, 22);
            this.txtDeleteLogs.TabIndex = 51;
            // 
            // lblDeleteLogs
            // 
            this.lblDeleteLogs.AutoSize = true;
            this.lblDeleteLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteLogs.Location = new System.Drawing.Point(55, 68);
            this.lblDeleteLogs.Name = "lblDeleteLogs";
            this.lblDeleteLogs.Size = new System.Drawing.Size(67, 13);
            this.lblDeleteLogs.TabIndex = 50;
            this.lblDeleteLogs.Text = "Delete Logs:";
            // 
            // chkVerboseLogging
            // 
            this.chkVerboseLogging.AutoSize = true;
            this.chkVerboseLogging.Location = new System.Drawing.Point(134, 29);
            this.chkVerboseLogging.Name = "chkVerboseLogging";
            this.chkVerboseLogging.Size = new System.Drawing.Size(106, 17);
            this.chkVerboseLogging.TabIndex = 49;
            this.chkVerboseLogging.Text = "Verbose Logging";
            this.chkVerboseLogging.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(325, 341);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(415, 341);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Enabled = false;
            this.btnApply.Location = new System.Drawing.Point(504, 341);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 7;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // tvRootDialog
            // 
            this.tvRootDialog.Description = "TV Root Folder";
            this.tvRootDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // labelOptionsSab_test
            // 
            this.labelOptionsSab_test.AutoSize = true;
            this.labelOptionsSab_test.ForeColor = System.Drawing.Color.Red;
            this.labelOptionsSab_test.Location = new System.Drawing.Point(110, 292);
            this.labelOptionsSab_test.Name = "labelOptionsSab_test";
            this.labelOptionsSab_test.Size = new System.Drawing.Size(107, 13);
            this.labelOptionsSab_test.TabIndex = 51;
            this.labelOptionsSab_test.Text = "labelOptionsSab_test";
            // 
            // FrmOptions
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(594, 372);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.panelGeneral);
            this.Controls.Add(this.panelShows);
            this.Controls.Add(this.panelSab);
            this.Controls.Add(this.treeViewOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOptions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Options";
            this.panelSab.ResumeLayout(false);
            this.panelSab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelShows.ResumeLayout(false);
            this.panelShows.PerformLayout();
            this.panelGeneral.ResumeLayout(false);
            this.panelGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewOptions;
        private System.Windows.Forms.Panel panelSab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSabInfoPort;
        private System.Windows.Forms.Label lblSabInfoPort;
        private System.Windows.Forms.Label lblApiKey;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtApiKey;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblSabInfoHost;
        private System.Windows.Forms.TextBox txtSabInfoHost;
        private System.Windows.Forms.TextBox txtNzbDir;
        private System.Windows.Forms.Label lblNzbDir;
        private System.Windows.Forms.Button nzbDirBrowse;
        private System.Windows.Forms.TextBox txtTvTemplate;
        private System.Windows.Forms.Label lblTvTemplate;
        private System.Windows.Forms.TextBox txtTvDailyTemplate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPriorityHigh;
        private System.Windows.Forms.Button btnPriorityNormal;
        private System.Windows.Forms.Button btnPriorityLow;
        private System.Windows.Forms.TextBox txtPriority;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Panel panelShows;
        private System.Windows.Forms.CheckBox chkDownloadPropers;
        private System.Windows.Forms.Label lblDownloadQuality;
        private System.Windows.Forms.TextBox txtVideoExt;
        private System.Windows.Forms.Label lblVideoExt;
        private System.Windows.Forms.Button btnTvRootClear;
        private System.Windows.Forms.TextBox txtTvRoot;
        private System.Windows.Forms.Label lblTvRoot;
        private System.Windows.Forms.Button tvRootBrowse;
        private System.Windows.Forms.CheckBox chkReplaceChars;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.Button btn120Days;
        private System.Windows.Forms.Button btn60Days;
        private System.Windows.Forms.Button btn30Days;
        private System.Windows.Forms.TextBox txtDeleteLogs;
        private System.Windows.Forms.Label lblDeleteLogs;
        private System.Windows.Forms.CheckBox chkVerboseLogging;
        private System.Windows.Forms.Button btnTestSab;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.FolderBrowserDialog tvRootDialog;
        private System.Windows.Forms.FolderBrowserDialog nzbDirDialog;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblTimer;
        internal System.Windows.Forms.NumericUpDown numMinutes;
        private System.Windows.Forms.CheckBox chkSyncOnStart;
        private System.Windows.Forms.ComboBox comboBoxDefaultQuality;
        private System.Windows.Forms.Label labelOptionsSab_test;




    }
}