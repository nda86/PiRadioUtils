using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controls;

namespace PiRadioUtils
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm view = new MainForm();

            ConnectPresenter connectPresenter = new ConnectPresenter(view);

            Player player = new Player();
            PlayerPresenter playerPresenter = new PlayerPresenter(view, player);

            Cron cron = new Cron();
            CronPresenter cronPresenter = new CronPresenter(view, cron);

            Services services = new Services();
            ServicePresenter ServicePresenter = new ServicePresenter(view, services);
            
            

            Application.Run(view);
        }
    }
}
