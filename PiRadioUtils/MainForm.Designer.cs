namespace PiRadioUtils
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
            this.tabTabs = new System.Windows.Forms.TabControl();
            this.tabPlayer = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSongStatus = new System.Windows.Forms.Label();
            this.lblSongName = new System.Windows.Forms.Label();
            this.lblMPCVolume = new System.Windows.Forms.Label();
            this.trcMPCVolume = new System.Windows.Forms.TrackBar();
            this.lblRandom = new System.Windows.Forms.Label();
            this.lblRepeat = new System.Windows.Forms.Label();
            this.btnRepeat = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.grpVolume = new System.Windows.Forms.GroupBox();
            this.trcVolume = new System.Windows.Forms.TrackBar();
            this.lblVolume = new System.Windows.Forms.Label();
            this.btnVolumeMinus = new System.Windows.Forms.Button();
            this.btnMute = new System.Windows.Forms.Button();
            this.btnVolumePlus = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnUpdateCron = new System.Windows.Forms.Button();
            this.txtOutCronJobs = new System.Windows.Forms.RichTextBox();
            this.btnGetCronJob = new System.Windows.Forms.Button();
            this.tabServices = new System.Windows.Forms.TabPage();
            this.btnGetServices = new System.Windows.Forms.Button();
            this.tableServices = new System.Windows.Forms.DataGridView();
            this.colNumberPP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServiceStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServiceStart = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colServiceStop = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHost = new System.Windows.Forms.ComboBox();
            this.lblFlagConnect = new System.Windows.Forms.Label();
            this.lblConnectStatus = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnectSettingsOpen = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tabTabs.SuspendLayout();
            this.tabPlayer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trcMPCVolume)).BeginInit();
            this.grpVolume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trcVolume)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableServices)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTabs
            // 
            this.tabTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabTabs.Controls.Add(this.tabPlayer);
            this.tabTabs.Controls.Add(this.tabPage1);
            this.tabTabs.Controls.Add(this.tabServices);
            this.tabTabs.Enabled = false;
            this.tabTabs.Location = new System.Drawing.Point(0, 48);
            this.tabTabs.Name = "tabTabs";
            this.tabTabs.SelectedIndex = 0;
            this.tabTabs.Size = new System.Drawing.Size(778, 295);
            this.tabTabs.TabIndex = 0;
            this.tabTabs.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPlayer
            // 
            this.tabPlayer.Controls.Add(this.groupBox1);
            this.tabPlayer.Controls.Add(this.grpVolume);
            this.tabPlayer.Location = new System.Drawing.Point(4, 22);
            this.tabPlayer.Name = "tabPlayer";
            this.tabPlayer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlayer.Size = new System.Drawing.Size(770, 269);
            this.tabPlayer.TabIndex = 1;
            this.tabPlayer.Text = "Player";
            this.tabPlayer.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSongStatus);
            this.groupBox1.Controls.Add(this.lblSongName);
            this.groupBox1.Controls.Add(this.lblMPCVolume);
            this.groupBox1.Controls.Add(this.trcMPCVolume);
            this.groupBox1.Controls.Add(this.lblRandom);
            this.groupBox1.Controls.Add(this.lblRepeat);
            this.groupBox1.Controls.Add(this.btnRepeat);
            this.groupBox1.Controls.Add(this.btnRandom);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnPlayPause);
            this.groupBox1.Controls.Add(this.btnPrev);
            this.groupBox1.Location = new System.Drawing.Point(168, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 269);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MPC";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblSongStatus
            // 
            this.lblSongStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSongStatus.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSongStatus.Location = new System.Drawing.Point(16, 137);
            this.lblSongStatus.Name = "lblSongStatus";
            this.lblSongStatus.Size = new System.Drawing.Size(318, 22);
            this.lblSongStatus.TabIndex = 13;
            this.lblSongStatus.Text = "Song Status";
            this.lblSongStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSongName
            // 
            this.lblSongName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSongName.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSongName.Location = new System.Drawing.Point(16, 163);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(318, 35);
            this.lblSongName.TabIndex = 12;
            this.lblSongName.Text = "Artist - SongName";
            this.lblSongName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMPCVolume
            // 
            this.lblMPCVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblMPCVolume.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMPCVolume.Location = new System.Drawing.Point(79, 46);
            this.lblMPCVolume.Name = "lblMPCVolume";
            this.lblMPCVolume.Size = new System.Drawing.Size(188, 30);
            this.lblMPCVolume.TabIndex = 11;
            this.lblMPCVolume.Text = "100";
            this.lblMPCVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trcMPCVolume
            // 
            this.trcMPCVolume.AutoSize = false;
            this.trcMPCVolume.Location = new System.Drawing.Point(79, 79);
            this.trcMPCVolume.Maximum = 100;
            this.trcMPCVolume.Name = "trcMPCVolume";
            this.trcMPCVolume.Size = new System.Drawing.Size(188, 29);
            this.trcMPCVolume.TabIndex = 10;
            // 
            // lblRandom
            // 
            this.lblRandom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblRandom.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRandom.Location = new System.Drawing.Point(12, 46);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(61, 30);
            this.lblRandom.TabIndex = 9;
            this.lblRandom.Text = "off";
            this.lblRandom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRepeat
            // 
            this.lblRepeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblRepeat.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRepeat.Location = new System.Drawing.Point(273, 46);
            this.lblRepeat.Name = "lblRepeat";
            this.lblRepeat.Size = new System.Drawing.Size(61, 30);
            this.lblRepeat.TabIndex = 8;
            this.lblRepeat.Text = "off";
            this.lblRepeat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRepeat
            // 
            this.btnRepeat.Location = new System.Drawing.Point(273, 79);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Size = new System.Drawing.Size(61, 29);
            this.btnRepeat.TabIndex = 6;
            this.btnRepeat.Text = "Repeat";
            this.btnRepeat.UseVisualStyleBackColor = true;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(12, 79);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(61, 29);
            this.btnRandom.TabIndex = 7;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(259, 219);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 38);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(178, 219);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 38);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Location = new System.Drawing.Point(97, 219);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(75, 38);
            this.btnPlayPause.TabIndex = 1;
            this.btnPlayPause.Text = "Play/Pause";
            this.btnPlayPause.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(16, 219);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 38);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // grpVolume
            // 
            this.grpVolume.Controls.Add(this.trcVolume);
            this.grpVolume.Controls.Add(this.lblVolume);
            this.grpVolume.Controls.Add(this.btnVolumeMinus);
            this.grpVolume.Controls.Add(this.btnMute);
            this.grpVolume.Controls.Add(this.btnVolumePlus);
            this.grpVolume.Location = new System.Drawing.Point(8, 6);
            this.grpVolume.Name = "grpVolume";
            this.grpVolume.Size = new System.Drawing.Size(154, 269);
            this.grpVolume.TabIndex = 4;
            this.grpVolume.TabStop = false;
            this.grpVolume.Text = "Amixer Volume";
            // 
            // trcVolume
            // 
            this.trcVolume.Location = new System.Drawing.Point(6, 80);
            this.trcVolume.Maximum = 100;
            this.trcVolume.Name = "trcVolume";
            this.trcVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trcVolume.Size = new System.Drawing.Size(45, 177);
            this.trcVolume.TabIndex = 0;
            // 
            // lblVolume
            // 
            this.lblVolume.BackColor = System.Drawing.Color.Aqua;
            this.lblVolume.Font = new System.Drawing.Font("standard 07_57", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.ForeColor = System.Drawing.Color.Black;
            this.lblVolume.Location = new System.Drawing.Point(6, 29);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(141, 48);
            this.lblVolume.TabIndex = 3;
            this.lblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVolumeMinus
            // 
            this.btnVolumeMinus.Location = new System.Drawing.Point(72, 202);
            this.btnVolumeMinus.Name = "btnVolumeMinus";
            this.btnVolumeMinus.Size = new System.Drawing.Size(75, 55);
            this.btnVolumeMinus.TabIndex = 2;
            this.btnVolumeMinus.Text = "Volume -";
            this.btnVolumeMinus.UseVisualStyleBackColor = true;
            // 
            // btnMute
            // 
            this.btnMute.Location = new System.Drawing.Point(72, 80);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(75, 55);
            this.btnMute.TabIndex = 0;
            this.btnMute.Text = "Mute";
            this.btnMute.UseVisualStyleBackColor = true;
            // 
            // btnVolumePlus
            // 
            this.btnVolumePlus.Location = new System.Drawing.Point(72, 141);
            this.btnVolumePlus.Name = "btnVolumePlus";
            this.btnVolumePlus.Size = new System.Drawing.Size(75, 55);
            this.btnVolumePlus.TabIndex = 1;
            this.btnVolumePlus.Text = "Volume +";
            this.btnVolumePlus.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnUpdateCron);
            this.tabPage1.Controls.Add(this.txtOutCronJobs);
            this.tabPage1.Controls.Add(this.btnGetCronJob);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(770, 269);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Cron";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCron
            // 
            this.btnUpdateCron.Location = new System.Drawing.Point(199, 198);
            this.btnUpdateCron.Name = "btnUpdateCron";
            this.btnUpdateCron.Size = new System.Drawing.Size(121, 23);
            this.btnUpdateCron.TabIndex = 2;
            this.btnUpdateCron.Text = "Update Cron";
            this.btnUpdateCron.UseVisualStyleBackColor = true;
            // 
            // txtOutCronJobs
            // 
            this.txtOutCronJobs.Location = new System.Drawing.Point(8, 3);
            this.txtOutCronJobs.Name = "txtOutCronJobs";
            this.txtOutCronJobs.Size = new System.Drawing.Size(312, 189);
            this.txtOutCronJobs.TabIndex = 1;
            this.txtOutCronJobs.Text = "";
            // 
            // btnGetCronJob
            // 
            this.btnGetCronJob.Location = new System.Drawing.Point(8, 198);
            this.btnGetCronJob.Name = "btnGetCronJob";
            this.btnGetCronJob.Size = new System.Drawing.Size(121, 23);
            this.btnGetCronJob.TabIndex = 0;
            this.btnGetCronJob.Text = "Get Cron";
            this.btnGetCronJob.UseVisualStyleBackColor = true;
            // 
            // tabServices
            // 
            this.tabServices.Controls.Add(this.btnGetServices);
            this.tabServices.Controls.Add(this.tableServices);
            this.tabServices.Location = new System.Drawing.Point(4, 22);
            this.tabServices.Name = "tabServices";
            this.tabServices.Padding = new System.Windows.Forms.Padding(3);
            this.tabServices.Size = new System.Drawing.Size(770, 269);
            this.tabServices.TabIndex = 3;
            this.tabServices.Text = "Services";
            this.tabServices.UseVisualStyleBackColor = true;
            // 
            // btnGetServices
            // 
            this.btnGetServices.Location = new System.Drawing.Point(8, 171);
            this.btnGetServices.Name = "btnGetServices";
            this.btnGetServices.Size = new System.Drawing.Size(113, 23);
            this.btnGetServices.TabIndex = 1;
            this.btnGetServices.Text = "Get Services";
            this.btnGetServices.UseVisualStyleBackColor = true;
            // 
            // tableServices
            // 
            this.tableServices.AllowUserToAddRows = false;
            this.tableServices.AllowUserToDeleteRows = false;
            this.tableServices.AllowUserToOrderColumns = true;
            this.tableServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumberPP,
            this.colServiceName,
            this.colServiceStatus,
            this.colServiceStart,
            this.colServiceStop});
            this.tableServices.Location = new System.Drawing.Point(0, 0);
            this.tableServices.Name = "tableServices";
            this.tableServices.Size = new System.Drawing.Size(770, 165);
            this.tableServices.TabIndex = 0;
            // 
            // colNumberPP
            // 
            this.colNumberPP.Frozen = true;
            this.colNumberPP.HeaderText = "№";
            this.colNumberPP.Name = "colNumberPP";
            this.colNumberPP.ReadOnly = true;
            this.colNumberPP.Width = 30;
            // 
            // colServiceName
            // 
            this.colServiceName.Frozen = true;
            this.colServiceName.HeaderText = "Service";
            this.colServiceName.Name = "colServiceName";
            this.colServiceName.ReadOnly = true;
            this.colServiceName.Width = 200;
            // 
            // colServiceStatus
            // 
            this.colServiceStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colServiceStatus.HeaderText = "Status";
            this.colServiceStatus.Name = "colServiceStatus";
            this.colServiceStatus.ReadOnly = true;
            // 
            // colServiceStart
            // 
            this.colServiceStart.HeaderText = "start";
            this.colServiceStart.Name = "colServiceStart";
            this.colServiceStart.ReadOnly = true;
            this.colServiceStart.Width = 50;
            // 
            // colServiceStop
            // 
            this.colServiceStop.HeaderText = "stop";
            this.colServiceStop.Name = "colServiceStop";
            this.colServiceStop.ReadOnly = true;
            this.colServiceStop.Width = 50;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtHost);
            this.groupBox2.Controls.Add(this.lblFlagConnect);
            this.groupBox2.Controls.Add(this.lblConnectStatus);
            this.groupBox2.Controls.Add(this.btnDisconnect);
            this.groupBox2.Controls.Add(this.btnConnectSettingsOpen);
            this.groupBox2.Controls.Add(this.btnConnect);
            this.groupBox2.Location = new System.Drawing.Point(0, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(774, 41);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connect";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtHost
            // 
            this.txtHost.FormattingEnabled = true;
            this.txtHost.Items.AddRange(new object[] {
            "192.168.226.134"});
            this.txtHost.Location = new System.Drawing.Point(261, 13);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(185, 21);
            this.txtHost.TabIndex = 7;
            // 
            // lblFlagConnect
            // 
            this.lblFlagConnect.Location = new System.Drawing.Point(226, 0);
            this.lblFlagConnect.Name = "lblFlagConnect";
            this.lblFlagConnect.Size = new System.Drawing.Size(19, 13);
            this.lblFlagConnect.TabIndex = 5;
            // 
            // lblConnectStatus
            // 
            this.lblConnectStatus.BackColor = System.Drawing.Color.Aqua;
            this.lblConnectStatus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblConnectStatus.Location = new System.Drawing.Point(6, 13);
            this.lblConnectStatus.Name = "lblConnectStatus";
            this.lblConnectStatus.Size = new System.Drawing.Size(239, 21);
            this.lblConnectStatus.TabIndex = 3;
            this.lblConnectStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(558, 13);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(100, 22);
            this.btnDisconnect.TabIndex = 2;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            // 
            // btnConnectSettingsOpen
            // 
            this.btnConnectSettingsOpen.Location = new System.Drawing.Point(664, 13);
            this.btnConnectSettingsOpen.Name = "btnConnectSettingsOpen";
            this.btnConnectSettingsOpen.Size = new System.Drawing.Size(100, 22);
            this.btnConnectSettingsOpen.TabIndex = 0;
            this.btnConnectSettingsOpen.Text = "Connect Settings";
            this.btnConnectSettingsOpen.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(452, 13);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 22);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 346);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Radio Control";
            this.tabTabs.ResumeLayout(false);
            this.tabPlayer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trcMPCVolume)).EndInit();
            this.grpVolume.ResumeLayout(false);
            this.grpVolume.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trcVolume)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabServices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableServices)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabTabs;
        private System.Windows.Forms.TabPage tabPlayer;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnConnectSettingsOpen;
        private System.Windows.Forms.GroupBox grpVolume;
        private System.Windows.Forms.TrackBar trcVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Button btnVolumeMinus;
        private System.Windows.Forms.Button btnMute;
        private System.Windows.Forms.Button btnVolumePlus;
        private System.Windows.Forms.Label lblConnectStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRandom;
        private System.Windows.Forms.Label lblRepeat;
        private System.Windows.Forms.Button btnRepeat;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblSongName;
        private System.Windows.Forms.Label lblMPCVolume;
        private System.Windows.Forms.TrackBar trcMPCVolume;
        private System.Windows.Forms.Label lblSongStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox txtOutCronJobs;
        private System.Windows.Forms.Button btnGetCronJob;
        private System.Windows.Forms.Label lblFlagConnect;
        private System.Windows.Forms.TabPage tabServices;
        private System.Windows.Forms.DataGridView tableServices;
        private System.Windows.Forms.Button btnGetServices;
        private System.Windows.Forms.ComboBox txtHost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumberPP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceStatus;
        private System.Windows.Forms.DataGridViewButtonColumn colServiceStart;
        private System.Windows.Forms.DataGridViewButtonColumn colServiceStop;
        private System.Windows.Forms.Button btnUpdateCron;
    }
}

