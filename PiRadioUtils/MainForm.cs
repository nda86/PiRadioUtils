using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiRadioUtils
{
    public interface IServiceForm
    {
        ConnectSettingsForm ConnectSettingsForm { get; }
        event EventHandler getAllService;
        List<ServiceItem> showTable { set; }

        event EventHandler<string> startService;
        event EventHandler<string> stopService;
    }

    public interface IConnectForm
    {
        event EventHandler OpenSettings;
        event EventHandler ConnectSSH;
        event EventHandler DisconnectSSH;


        ConnectSettingsForm ConnectSettingsForm { get; }
        string connectionStatus { get; set; } 
        string host { get; }
        bool flagConnect { get; set; }
    }

    public interface IPlayerForm
    {

        event EventHandler minusVolume;
        event EventHandler plusVolume;
        event EventHandler changeTrackVolume;
        event EventHandler mute;
        event EventHandler enterVolumeTab;

        string currentLblVolume { set; get; }
        int currentTrcVolume { get; set; }
        bool flagConnect { get; set; }





        event EventHandler prevMPC;
        event EventHandler play_pauseMPC;
        event EventHandler stopMPC;
        event EventHandler nextMPC;
        event EventHandler repeatMPC;
        event EventHandler randomMPC;
        event EventHandler trcVolumeMPC;
        event EventHandler changeFlagConnection;

        string songName { set; }
        bool repeatStatus { set; }
        bool randomStatus { set; }
        string volumeMPC { set; get; }
        string songStatus { set; }

    }

    public interface ICronForm
    {
        event EventHandler getCronJob;
        event EventHandler updateCronJob;
        string outCron { set; get; }
        bool flagConnect { get; set; }

        event EventHandler changeFlagConnection;
    }


    public partial class MainForm : Form, IConnectForm, IPlayerForm, ICronForm, IServiceForm
    {
        private bool _flagConnect;
        public MainForm()
        {
            InitializeComponent();

            lblFlagConnect.BackColorChanged += LblFlagConnect_BackColorChanged;

            btnDisconnect.Enabled = false;
            
            tabPlayer.Enabled = false;

            //cmbHost.SelectionStart = 0;
            
            btnConnectSettingsOpen.Click += BtnConnectSettingsOpen_Click;
            btnConnect.Click += BtnConnect_Click;
            btnDisconnect.Click += BtnDisconnect_Click;


            btnVolumePlus.Click += BtnVolumePlus_Click;
            btnVolumeMinus.Click += BtnVolumeMinus_Click;
            trcVolume.MouseUp += TrcVolume_KeyUp;
            btnMute.Click += BtnMute_Click;
            
            tabPlayer.Enter += TabPlayer_Enter;
            btnPrev.Click += BtnPrev_Click;
            btnPlayPause.Click += BtnPlayPause_Click;
            btnStop.Click += BtnStop_Click;
            btnNext.Click += BtnNext_Click;
            trcMPCVolume.MouseUp += TrcMPCVolume_MouseUp;
            btnRepeat.Click += BtnRepeat_Click;
            btnRandom.Click += BtnRandom_Click;


            btnGetCronJob.Click += BtnGetCronJob_Click;
            btnUpdateCron.Click += BtnUpdateCron_Click;

            btnGetServices.Click += BtnGetServices_Click;
            tableServices.CellContentClick += TableServices_CellContentClick;
        }

        private void BtnUpdateCron_Click(object sender, EventArgs e)
        {
            if (updateCronJob != null) updateCronJob(this, EventArgs.Empty);
        }

        private void BtnGetServices_Click(object sender, EventArgs e)
        {
            if (getAllService != null) getAllService(this, EventArgs.Empty);
        }

        private void LblFlagConnect_BackColorChanged(object sender, EventArgs e)
        {
            if (_flagConnect && (changeFlagConnection != null)) changeFlagConnection(this, EventArgs.Empty);
        }

        private void BtnGetCronJob_Click(object sender, EventArgs e)
        {
            if (getCronJob != null) getCronJob(this, EventArgs.Empty);
        }

        private void BtnSearchIP_Click(object sender, EventArgs e)
        {
            if (searchIP != null) searchIP(this, EventArgs.Empty);
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            if (randomMPC != null) randomMPC(this, EventArgs.Empty);
        }

        private void BtnRepeat_Click(object sender, EventArgs e)
        {
            if (repeatMPC != null) repeatMPC(this, EventArgs.Empty);
        }

        private void TrcMPCVolume_MouseUp(object sender, MouseEventArgs e)
        {
            if (trcVolumeMPC != null) trcVolumeMPC(this, EventArgs.Empty);
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (nextMPC != null) nextMPC(this, EventArgs.Empty);
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            if (stopMPC != null) stopMPC(this, EventArgs.Empty);
        }

        private void BtnPlayPause_Click(object sender, EventArgs e)
        {
            if (play_pauseMPC != null) play_pauseMPC(this, EventArgs.Empty);
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            if (nextMPC != null) prevMPC(this, EventArgs.Empty);
        }

        private void TabPlayer_Enter(object sender, EventArgs e)
        {
            if (enterVolumeTab != null) enterVolumeTab(this, EventArgs.Empty);
        }

        public ConnectSettingsForm ConnectSettingsForm
        {
            get
            {
                return new ConnectSettingsForm();
            }
        }

        public string currentLblVolume
        {
            get
            {
                return lblVolume.Text;
            }

            set
            {
                if (value == "Mute")
                {
                    lblVolume.Text = "Muted";
                    btnVolumeMinus.Enabled = false;
                    btnVolumePlus.Enabled = false;
                    trcVolume.Enabled = false;
                }
                else
                {
                    lblVolume.Text = value;
                    btnVolumeMinus.Enabled = true;
                    btnVolumePlus.Enabled = true;
                    trcVolume.Enabled = true;
                }
                
            }
        }

        public int  currentTrcVolume
        {

            set
            {
                trcVolume.Value = value;
            }
            get
            {
                return trcVolume.Value;
            }
        }

        public string connectionStatus
        {
            get
            {
                return lblConnectStatus.Text;
            }

            set
            {
                switch (value)
                {
                    case "connect":
                        lblConnectStatus.Text = "Connecting People!";
                        lblConnectStatus.ForeColor = System.Drawing.Color.Green;
                        btnConnectSettingsOpen.Enabled = false;
                        btnDisconnect.Enabled = true;
                        btnConnect.Enabled = false;
                        tabPlayer.Enabled = true;
                        tabTabs.Enabled = true;
                        
                        break;
                    case "disconnect":
                        lblConnectStatus.Text = "Disconnect!";
                        lblConnectStatus.ForeColor = System.Drawing.Color.Red;
                        btnConnectSettingsOpen.Enabled = true;
                        btnConnect.Enabled = true;
                        btnDisconnect.Enabled = false;
                        tabPlayer.Enabled = false;
                        tabTabs.Enabled = false;
                        break;
                    default:
                        break;
                }
                
            }
        }

        public string songName
        {
            set
            {
                if (value == "")
                {
                    lblSongName.Text = "STOP";
                }
                else
                {
                    lblSongName.Text = value;
                }
                
            }
        }

        public bool repeatStatus
        {
            set
            {
                if (value)
                {
                    lblRepeat.Text = "on";
                    lblRepeat.ForeColor = System.Drawing.Color.Green;
                } else
                {
                    lblRepeat.Text = "off";
                    lblRepeat.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        public bool randomStatus
        {
            set
            {
                if (value)
                {
                    lblRandom.Text = "on";
                    lblRandom.ForeColor = System.Drawing.Color.Green;
                } else
                {
                    lblRandom.Text = "off";
                    lblRandom.ForeColor = System.Drawing.Color.Red;

                }
            }
        }

        public string volumeMPC
        {
            set
            {
                trcMPCVolume.Value = int.Parse(value);
                lblMPCVolume.Text = value;
            }
            get
            {
                return trcMPCVolume.Value.ToString();
            }
        }

        public string songStatus
        {
            set
            {
                lblSongStatus.Text = value;
            }
        }

        public string outCron
        {
            set
            {
                txtOutCronJobs.Text = value;
            }
            get
            {
                return txtOutCronJobs.Text;
            }
        }

        public string host
        {
            get
            {
                try
                {
                    return txtHost.Text;
                }
                catch (Exception ex)
                {
                    return "127.0.0.1";
                }
                
            }
        }

        public bool flagConnect
        {
            get
            {
                return _flagConnect;
            }

            set
            {
               if (value)
                {
                    _flagConnect = true;
                    lblFlagConnect.BackColor = System.Drawing.Color.Green;
                   
                }
                else
                {
                    _flagConnect = false;
                    lblFlagConnect.BackColor = System.Drawing.Color.Red;
                    
                }
            }
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            if (DisconnectSSH != null) DisconnectSSH(this, EventArgs.Empty);
        }

        private void BtnMute_Click(object sender, EventArgs e)
        {
            if (mute != null) mute(this, EventArgs.Empty);
        }

        private void TrcVolume_KeyUp(object sender, MouseEventArgs e)
        {
            if (changeTrackVolume != null) changeTrackVolume(this, EventArgs.Empty);
        }

        private void BtnVolumeMinus_Click(object sender, EventArgs e)
        {
            if (minusVolume != null) minusVolume(this, EventArgs.Empty);
        }

        private void BtnVolumePlus_Click(object sender, EventArgs e)
        {
            if (plusVolume != null) plusVolume(this, EventArgs.Empty);
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (ConnectSSH != null) ConnectSSH(this, EventArgs.Empty);
        }

        private void BtnConnectSettingsOpen_Click(object sender, EventArgs e)
        {
            if (OpenSettings != null) OpenSettings(this, EventArgs.Empty);
        }




        public event EventHandler OpenSettings;
        public event EventHandler ConnectSSH;
        public event EventHandler minusVolume;
        public event EventHandler plusVolume;
        public event EventHandler changeTrackVolume;
        public event EventHandler mute;
        public event EventHandler DisconnectSSH;
        public event EventHandler enterVolumeTab;
        public event EventHandler prevMPC;
        public event EventHandler play_pauseMPC;
        public event EventHandler stopMPC;
        public event EventHandler nextMPC;
        public event EventHandler repeatMPC;
        public event EventHandler randomMPC;
        public event EventHandler trcVolumeMPC;
        public event EventHandler searchIP;
        public event EventHandler getCronJob;
        public event EventHandler changeFlagConnection;
        public event EventHandler AddIP;
        public event EventHandler getAllService;
        public event EventHandler<string> startService;
        public event EventHandler<string> stopService;
        public event EventHandler updateCronJob;

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnConnect.Enabled)
            {
               // tabControl1.SelectedTab = tabConnect;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        public List<ServiceItem> showTable
        {
            set
            {
                tableServices.Rows.Clear();
                foreach (ServiceItem service in value)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(tableServices);
                    row.Cells[0].Value = service.numberPP;
                    row.Cells[1].Value = service.nameService;
                    row.Cells[2].Value = service.statusService;
                    tableServices.Rows.Add(row);
                }
            }
        }



        private void TableServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string serviceName = tableServices.Rows[e.RowIndex].Cells[1].Value.ToString();
                switch (e.ColumnIndex)
                {
                    case 3:
                        if (startService != null) startService(this, serviceName);
                        break;
                    case 4:
                        if (stopService != null) stopService(this, serviceName);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
