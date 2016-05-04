using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;

namespace Controls
{
  public class SSH
    {
        private static SshClient _sshClient;
        public static SshClient sshClient
        {
            get
            {
                return _sshClient;
            }
        }


        public static bool SSHConnect(string host, string user, string password)
        {

            
            ConnectionInfo conn =  new ConnectionInfo(host, user, new AuthenticationMethod[]
            {
                new PasswordAuthenticationMethod(user, password),
            });
            _sshClient = new SshClient(conn);
            _sshClient.Connect();
            if (_sshClient.IsConnected)
            {

                return true;
            }
            else
            {
                return false;
            }
        }
        public static void SSHDisconnect()
        {
            _sshClient.Disconnect();
            _sshClient = null;
        }
    }
}
