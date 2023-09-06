using NLog;
using SOI_Basemap_Publiser_Application_UI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOI_Basemap_Publiser_Application_UI
{
    public partial class MainForm : Form
    {
        private const string _SERVICE_NAME = "SOIBasemapPublish";
        private static Logger _logger = LogManager.GetLogger("AppLog");
        public MainForm()
        {
            InitializeComponent();
            btnStart.Enabled = true;
            btnRestart.Enabled = false;
            btnStop.Enabled = false;

            ntfySOIBasemap = new NotifyIcon(this.components);
            ntfySOIBasemap.Icon = this.Icon;
            ntfySOIBasemap.Text = "SOI Basemap Publish Controller";
            ntfySOIBasemap.Visible = true;

            ntfySOIBasemap.ContextMenuStrip = cntxtSOIBasemapMenuStrip;

        }

        private void showControllerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void quitControllerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ask = MessagePopup.AskConfirmation("Are you sure you want to close the application");

            if(ask)
                Application.Exit();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CheckService();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Visible = false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                _logger.Info("Service start clicked");
                _logger.Info("");

                bool started = ServiceControllerHelper.StartService(_SERVICE_NAME);
                CheckService();
            }
            catch (Exception ex)
            {
                _logger.Fatal(ex);
                _logger.Fatal("");

                MessagePopup.ShowError(ex.Message + "\r\n" + ex.InnerException);
            }
            finally
            {
                Cursor.Current  = Cursors.Default;
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                _logger.Info("Service restart clicked");
                _logger.Info("");

                bool restart = ServiceControllerHelper.RestartService(_SERVICE_NAME);
                CheckService();
            }
            catch (Exception ex)
            {
                _logger.Fatal(ex);
                _logger.Fatal("");

                MessagePopup.ShowError(ex.Message + "\r\n" + ex.InnerException);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                _logger.Info("Service stop clicked");
                _logger.Info("");

                bool stopped = ServiceControllerHelper.StopService(_SERVICE_NAME);
                CheckService();
            }
            catch (Exception ex)
            {
                _logger.Fatal(ex);
                _logger.Fatal("");

                MessagePopup.ShowError(ex.Message + "\r\n" + ex.InnerException);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void CheckService()
        {
            try
            {
                ServiceStatus checkStatus = ServiceControllerHelper.CheckServiceStatus(_SERVICE_NAME);

                if (checkStatus == ServiceStatus.Running)
                {
                    btnStart.Enabled = false;
                    btnRestart.Enabled = true;
                    btnStop.Enabled = true;
                    txtServiceStatus.Text = checkStatus.ToString();
                }
                else if (checkStatus == ServiceStatus.Stopped)
                {
                    btnStart.Enabled = true;
                    btnRestart.Enabled = false;
                    btnStop.Enabled = false;
                    txtServiceStatus.Text = checkStatus.ToString();
                }
                else if (checkStatus == ServiceStatus.DoesNotExist)
                {
                    btnStart.Enabled = true;
                    btnRestart.Enabled = false;
                    btnStop.Enabled = false;
                    txtServiceStatus.Text = "Service not installed";
                }
            }
            catch (Exception ex)
            {
                _logger.Fatal(ex);
                _logger.Fatal("");

                MessagePopup.ShowError(ex.Message + "\r\n"+ex.InnerException);
            }
        }

    }
}
