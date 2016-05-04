using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;

namespace Controls
{
    public interface ICron
    {
        string getAllCronJobs();
        string updateCronJob(string cronJobList);

    }
    public class Cron : ICron
    {
        private SshClient sshClient = null;
        public string getAllCronJobs()
        {
            sshClient = SSH.sshClient;
            using (var cmd = sshClient.CreateCommand("crontab -l"))
            {
                cmd.Execute();
                if (cmd.ExitStatus == 0)
                {
                    return cmd.Result.ToString();
                }
                else
                {
                    return "Hmm.. something went wrong. Maybe you have not any cron jobs";
                }

                
            }
        }

        public string updateCronJob(string cronJobList)
        {
            string[] result;
            using (var cmd = sshClient.CreateCommand
("echo " + "'" + cronJobList + "'" + " > cron_tmp; crontab cron_tmp pi; rm -f cron_tmp"))
            {
                cmd.Execute();
                if (cmd.Error == "")
                {
                     
                    return "";
                }
                else
                {
                    return cmd.Error;
                }
            }
        }
    }
}
