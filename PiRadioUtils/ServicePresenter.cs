using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controls;
using PiRadioUtils.Properties;
using System.Threading;
using System.Windows.Forms;

namespace PiRadioUtils
{

    class ServicePresenter
    {
        private readonly IServiceForm _view;
        private readonly IServices _services;
        private readonly string[] _listOfServices = new string[] { "mpd", "cron", "smbd", "nmbd" };

        public ServicePresenter(IServiceForm view, IServices services)
        {
            this._view = view;
            this._services = services;

            _view.getAllService += _view_getAllService;
            _view.startService += _view_startService;
            _view.stopService += _view_stopService;
        }


        private void _view_stopService(object sender, string serviceName)
        {

            try
            {
            _services.doActionService(serviceName, "stop", _view.ConnectSettingsForm.password);
            _view_getAllService(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _view_startService(object sender, string serviceName)
        {

            try
            {
                _services.doActionService(serviceName, "start", _view.ConnectSettingsForm.password);
                _view_getAllService(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _view_getAllService(object sender, EventArgs e)
        {
            try
            {
                List<ServiceItem> listServiceItem = new List<ServiceItem>();
                string password = _view.ConnectSettingsForm.password;
                for (int i = 0; i < _listOfServices.Length; i++)
                {
                    ServiceItem service = new ServiceItem();
                    service.numberPP = i + 1;
                    service.nameService = _listOfServices[i];
                    service.statusService = _services.getServiceStatus(_listOfServices[i], password);
                    listServiceItem.Add(service);
                }
                _view.showTable = listServiceItem;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }



    public class ServiceItem
    {
        public int numberPP;
        public string nameService;
        public string statusService;
    }


}
