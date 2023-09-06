using NLog;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;
using System.Threading.Tasks;

namespace SOIBasemapPublisherProcess
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        private static Logger _logger = LogManager.GetLogger("AppLog");
        public ProjectInstaller()
        {
            InitializeComponent();
        }

        private void SOIBasemapPublishServiceInstaller_AfterInstall(object sender, InstallEventArgs e)
        {
            try
            {
                ServiceInstaller serviceInstaller = (ServiceInstaller)sender;
                using (ServiceController serviceController = new ServiceController(serviceInstaller.ServiceName))
                {
                    _logger.Info("service starting from the MSI");
                    _logger.Info("");

                    serviceController.Start();
                }
            }
            catch (Exception ex)
            {
                _logger.Fatal(ex);
                _logger.Fatal("");
            }
        }
    }
}
