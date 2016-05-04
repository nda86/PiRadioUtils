using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controls;
using System.Windows.Forms;

namespace PiRadioUtils
{
    public class CronPresenter
    {
        private readonly ICronForm _view;
        private readonly ICron _cron;
        private string currentCronJob = null;
        public CronPresenter(ICronForm view, ICron cron)
        {
            _view = view;
            _cron = cron;

            _view.getCronJob += _view_getCronJob;
            _view.updateCronJob += _view_updateCronJob;
        }

        private void _view_updateCronJob(object sender, EventArgs e)
        {
            string cronJobList = _view.outCron;
            string res = _cron.updateCronJob(cronJobList);
            if (res != "")
            {
                MessageBox.Show(res);
                _view.outCron = currentCronJob;
                //_view_getCronJob(this, e);
            }
        }

        private void _view_getCronJob(object sender, EventArgs e)
        {
            string cronJobs =  _cron.getAllCronJobs();
            currentCronJob = cronJobs;
            _view.outCron = cronJobs;
        }
    }
}
