using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace SOI_Basemap_Publiser_Application_UI.Helper
{
    internal class ServiceControllerHelper
    {
        internal static ServiceStatus CheckServiceStatus(string serviceName)
        {
            try
            {
                if (!ServiceExists(serviceName))
                    return ServiceStatus.DoesNotExist;

                using (ServiceController service = new ServiceController(serviceName))
                {
                    if (service == null)
                        return ServiceStatus.Stopped;
                    if (service.Status == ServiceControllerStatus.Running)
                        return ServiceStatus.Running;
                    else
                        return ServiceStatus.Stopped;
                }
            }
            catch (Exception ex)
            {
                //_logger.Fatal(ex);
                return ServiceStatus.Stopped;
            }
        }

        internal static bool ServiceExists(string serviceName)
        {
            ServiceController[] services = ServiceController.GetServices();
            var service = services.FirstOrDefault(s => string.Equals(s.ServiceName, serviceName, StringComparison.OrdinalIgnoreCase));
            return service != null;
        }

        internal static bool StartService(string serviceName)
        {
            if (!ServiceExists(serviceName))
                return false;

            using (ServiceController service = new ServiceController(serviceName))
            {
                service.Start();
                service.WaitForStatus(ServiceControllerStatus.Running);
                return true;
            }
        }

        internal static bool StopService(string serviceName)
        {
            if (!ServiceExists(serviceName))
                return false;

            using (ServiceController service = new ServiceController(serviceName))
            {
                service.Stop();
                service.WaitForStatus(ServiceControllerStatus.Stopped);
                return true;
            }
        }

        internal static bool RestartService(string serviceName)
        {
            if (!ServiceExists(serviceName))
                return false;

            using (ServiceController service = new ServiceController(serviceName))
            {
                int timeoutMilliseconds = 10;
                int millisec1 = Environment.TickCount;
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);
                service.Stop();
                service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);

                int millisec2 = Environment.TickCount;
                timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds - (millisec2 - millisec1));
                service.Start();
                service.WaitForStatus(ServiceControllerStatus.Running, timeout);
                return true;
            }
        }
    }
}
