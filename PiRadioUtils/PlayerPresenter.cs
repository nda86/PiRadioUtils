using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controls;
using System.Windows.Forms;

namespace PiRadioUtils
{
    public class PlayerPresenter
    {
        private readonly IPlayerForm _view;
        private readonly IPlayer _player;
        public PlayerPresenter(IPlayerForm view, IPlayer player)
        {
            _view = view;
            _player = player;
            _view.minusVolume += _view_minusVolume;
            _view.plusVolume += _view_plusVolume;
            _view.enterVolumeTab += _view_enterVolumeTab;
            _view.changeTrackVolume += _view_changeTrackVolume;
            _view.mute += _view_mute;


            _view.prevMPC += _view_prevMPC;
            _view.play_pauseMPC += _view_play_pauseMPC;
            _view.stopMPC += _view_stopMPC;
            _view.nextMPC += _view_nextMPC;
            _view.randomMPC += _view_randomMPC;
            _view.repeatMPC += _view_repeatMPC;
            _view.trcVolumeMPC += _view_trcVolumeMPC;

            _view.changeFlagConnection += _view_changeFlagConnection;
            
        }

        private void _view_changeFlagConnection(object sender, EventArgs e)
        {
            refreshVolume();
            refreshMPC();
            
        }

        void refreshMPC()
        {
            _view.songName = _player.getMPCSong();
            _view.repeatStatus = _player.getRepeatStatus();
            _view.randomStatus = _player.getRandomStatus();
            _view.volumeMPC = _player.getVolumeMPC();
            _view.songStatus = _player.getStatusSong();
        }

        private void _view_trcVolumeMPC(object sender, EventArgs e)
        {
            string newVolume = _view.volumeMPC;
            _player.setVolumeMPC(newVolume);
            refreshMPC();
        }

        private void _view_repeatMPC(object sender, EventArgs e)
        {
            _player.toggleRepeat();
            refreshMPC();
        }

        private void _view_randomMPC(object sender, EventArgs e)
        {
            _player.toggleRandom();
            refreshMPC();
        }

        private void _view_nextMPC(object sender, EventArgs e)
        {
            _player.nextMPC();
            refreshMPC();
        }

        private void _view_stopMPC(object sender, EventArgs e)
        {
            _player.stopMPC();
            refreshMPC();
        }

        private void _view_play_pauseMPC(object sender, EventArgs e)
        {
            _player.play_pauseMPC();
            refreshMPC();
        }

        private void _view_prevMPC(object sender, EventArgs e)
        {
            _player.prevMPC();
            refreshMPC();
        }

        private void _view_mute(object sender, EventArgs e)
        {
            if (_player.getMuteStatus())
            {
                _player.unmute();

            }
            else
            {
                _player.mute();
            }
            refreshVolume();
        }

        private void _view_changeTrackVolume(object sender, EventArgs e)
        {
            string newVolume = _view.currentTrcVolume.ToString();
            _player.setVolume(newVolume + "%");
            refreshVolume();
        }

        private void _view_enterVolumeTab(object sender, EventArgs e)
        {
            try
            {
                refreshVolume();
                refreshMPC();
            }
            catch (Exception)
            {

                MessageBox.Show("Not Connection!");
            }
            
        }

        void refreshVolume()
        {
            string fuck = _player.getVolume();
            if (_player.getMuteStatus())
            {
                _view.currentLblVolume = "Mute";

            }
            else
            {
                _view.currentLblVolume = _player.getVolume();
            }
            _view.currentTrcVolume = Int32.Parse(_player.getVolume());


        }

        private void _view_plusVolume(object sender, EventArgs e)
        {
            //string newVolume = (Int32.Parse(_player.getVolume()) + 1).ToString();
            string newVolume = "1+";
            _player.setVolume(newVolume);
            refreshVolume();
        }

        private void _view_minusVolume(object sender, EventArgs e)
        {
            //string newVolume = (Int32.Parse(_player.getVolume()) - 2).ToString();
            string newVolume = "1-";
            _player.setVolume(newVolume);
            refreshVolume();
        }
    }
}
