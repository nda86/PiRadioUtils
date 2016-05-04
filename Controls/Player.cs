using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;
namespace Controls
{
    public interface IPlayer
    {
        string getVolume();
        void setVolume(string volume);
        void mute();
        void unmute();
        bool getMuteStatus();



        void prevMPC();
        void play_pauseMPC();
        void stopMPC();
        void nextMPC();
        string getMPCSong();
        bool getRepeatStatus();
        bool getRandomStatus();
        void toggleRepeat();
        void toggleRandom();
        void setVolumeMPC(string volume);
        string getVolumeMPC();
        string getStatusSong();



    }
    public class Player : IPlayer
    {
        private SshClient sshClient = null;

  
        public string getVolume()
        {
            sshClient = SSH.sshClient;
            using (var cmd = sshClient.CreateCommand("amixer sget PCM | awk -F '[][]' '/dB/ {print $2}' | sed 's/%//' | head -n 1"))
            {
                cmd.Execute();
                return cmd.Result.ToString();
            }
        }

        public void mute()
        {
            using (var cmd = sshClient.CreateCommand("amixer set PCM mute"))
            {
                cmd.Execute();
            }
        }

        public bool getMuteStatus()
        {
            using (var cmd = sshClient.CreateCommand("amixer sget PCM | awk -F '[][]' '/dB/ {print $6}' | head -n 1"))
            {
                string result = cmd.Execute();
                if (result == "off\n")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void setVolume(string volume)
        {

            using (var cmd = sshClient.CreateCommand("amixer set PCM " + volume))
            {
                cmd.Execute();
            }
        }

        public void unmute()
        {
            using (var cmd = sshClient.CreateCommand("amixer set PCM unmute"))
            {
                cmd.Execute();
            }
        }








        public void prevMPC()
        {
            using (var cmd = sshClient.CreateCommand("mpc prev"))
            {
                cmd.Execute();
            }
        }

        public void play_pauseMPC()
        {
            using (var cmd = sshClient.CreateCommand("mpc toggle"))
            {
                cmd.Execute();
            }
        }

        public void stopMPC()
        {
            using (var cmd = sshClient.CreateCommand("mpc stop"))
            {
                cmd.Execute();
            }
        }

        public void nextMPC()
        {
            using (var cmd = sshClient.CreateCommand("mpc next"))
            {
                cmd.Execute();
            }
        }

        public string getMPCSong()
        {
            using (var cmd = sshClient.CreateCommand("mpc current"))
            {
                return cmd.Execute();
            }
        }

        public bool getRepeatStatus()
        {
            using (var cmd = sshClient.CreateCommand("mpc status | egrep -o 'repeat:.{,4}' | awk -F ':' '{print $2}' | sed 's/ //g' | sed 's/[[:blank:]]//g' | sed 's/[[:space:]]//g'"))
            {
                if (cmd.Execute() == "on\n")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool getRandomStatus()
        {
            using (var cmd = sshClient.CreateCommand("mpc status | egrep -o 'random:.{,4}' | awk -F ':' '{print $2}' | sed 's/ //g' | sed 's/[[:blank:]]//g' | sed 's/[[:space:]]//g'"))
            {
                if (cmd.Execute() == "on\n")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void toggleRepeat()
        {
            using (var cmd = sshClient.CreateCommand("mpc repeat"))
            {
                cmd.Execute();
            }
        }

        public void toggleRandom()
        {
            using (var cmd = sshClient.CreateCommand("mpc random"))
            {
                cmd.Execute();
            }
        }

        public void setVolumeMPC(string volume)
        {
            using (var cmd = sshClient.CreateCommand("mpc volume " + volume))
            {
                cmd.Execute();
            }
        }

        public string getVolumeMPC()
        {
            using (var cmd = sshClient.CreateCommand("mpc volume | awk -F ':' '{print $2}' | sed 's/%//'"))
            {
                return cmd.Execute();

            }
        }

        public string getStatusSong()
        {
            using (var cmd = sshClient.CreateCommand("mpc status | sed -n 2p"))
            {
                return cmd.Execute();
            }
        }
    }
}
