using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;

namespace Controls
{
    public interface IServices
    {
        string getServiceStatus(string serviceName, string pass);
        void doActionService(string serviceName, string action, string password);
    }



    public class Services : IServices
    {
        SshClient sshClient = null;

        public void doActionService(string serviceName, string action, string password)
        {
            using (var cmd = sshClient.CreateCommand("echo " + password + " | sudo -S service " +
    serviceName + " " + action))
            {
                cmd.Execute();
            }
        }

        public string getServiceStatus(string serviceName, string pass)
        {
            sshClient = SSH.sshClient;
            using (var cmd = sshClient.CreateCommand("echo " + pass + " | sudo -S service " + 
                serviceName + " status"))
            {
                cmd.Execute();
                return cmd.Result.ToString();
            }
        }
    }


}
