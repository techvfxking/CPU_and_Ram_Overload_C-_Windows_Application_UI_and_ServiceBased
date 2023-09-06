using ServiceProcess.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace SOIBasemapPublisherProcess
{
    internal static class Program
    {
        private static readonly List<ServiceBase> _servicesToRun = new List<ServiceBase>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            _servicesToRun.Add(SOIBasemapPublishProcess.Instance);
            if (Environment.UserInteractive)
            {
                _servicesToRun.ToArray().LoadServices();
            }
            else
            {
                ServiceBase.Run(_servicesToRun.ToArray());
            }
        }
    }
}
