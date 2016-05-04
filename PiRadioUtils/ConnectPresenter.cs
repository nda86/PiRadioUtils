using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PiRadioUtils.Properties;
using Controls;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;


namespace PiRadioUtils
{

    public class ConnectPresenter
    {
        private readonly IConnectForm _view;


        public ConnectPresenter(IConnectForm view)
        {
            _view = view;
            _view.OpenSettings += _view_OpenSettings;
            _view.ConnectSSH += _view_ConnectSSH;
            _view.DisconnectSSH += _view_DisconnectSSH;
            //_view.searchIP += _view_searchIP;
        }


        //private void _view_searchIP(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string subnet = _view.subnetIP;
        //        IPAddress ip;
        //        Ping pinger = new Ping();
        //        PingReply reply;
        //        //List<IPAddress> outIP = new List<IPAddress>();
        //        for (int i = 1; i<10; i++)
        //        {
        //            ip = IPAddress.Parse("192.168." + subnet + "." + i.ToString());
        //            reply = pinger.Send(ip);
        //            if (reply.Status != IPStatus.Success)
        //            {
        //                continue;
        //            }
        //            //if (tryConnectSSH(ip.ToString()))
        //            //{
        //            //    _view.findIP = ip.ToString();
        //            //    break;
        //            //}
        //            _view.findIP = ip.ToString();


        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }

        //}

        private void _view_DisconnectSSH(object sender, EventArgs e)
        {
            SSH.SSHDisconnect();
            _view.connectionStatus = "disconnect";
            _view.flagConnect = false;
        }

        private void _view_ConnectSSH(object sender, EventArgs e)
        {
            string host = _view.host;
            string user = _view.ConnectSettingsForm.user;
            string password = _view.ConnectSettingsForm.password;
            try
            {
                if (SSH.SSHConnect(host, user, password))
                {
                    _view.connectionStatus = "connect";
                    _view.flagConnect = true;                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);         
            }
            
        }

        //private bool tryConnectSSH(string host)
        //{
        //    string user = "user";
        //    string password = "password";
        //    try
        //    {
        //       if (SSH.SSHConnect(host, user, password))
        //        {
        //            return true;
        //        }
        //        return false;
               
        //    }
        //    catch (System.Net.Sockets.SocketException)
        //    {
        //        return false;
        //    }
        //    catch (Exception)
        //    {
        //        return true;
        //    }
            
        //}

        private void _view_OpenSettings(object sender, EventArgs e)
        {
            _view.ConnectSettingsForm.ShowDialog();
        }




    }
}
