using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PiRadioUtils.Properties;
namespace PiRadioUtils
{
    public partial class ConnectSettingsForm : Form
    {
        public ConnectSettingsForm()
        {
            InitializeComponent();
            btnConnectSettingsSave.Click += BtnConnectSettingsSave_Click;
            txtUser.Text = user;
            txtPassword.Text = password;
        }

        private void BtnConnectSettingsSave_Click(object sender, EventArgs e)
        {
            user = txtUser.Text;
            password = txtPassword.Text;
            Settings.Default.Save();
            Close();
        }


        public string user
        {
            get
            {
                return Settings.Default["user"].ToString();
            }
            set
            {
                Settings.Default["user"] = value;
            }
        }

        public string password
        {
            get
            {
                return Settings.Default["password"].ToString();
            }
            set
            {
                Settings.Default["password"] = value;
            }
        }
    }
}
