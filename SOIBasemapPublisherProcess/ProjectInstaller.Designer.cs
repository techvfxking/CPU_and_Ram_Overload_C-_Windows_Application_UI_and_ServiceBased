namespace SOIBasemapPublisherProcess
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SOIBasemapPublishInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.SOIBasemapPublishServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // SOIBasemapPublishInstaller
            // 
            this.SOIBasemapPublishInstaller.Account = System.ServiceProcess.ServiceAccount.LocalService;
            this.SOIBasemapPublishInstaller.Password = null;
            this.SOIBasemapPublishInstaller.Username = null;
            // 
            // SOIBasemapPublishServiceInstaller
            // 
            this.SOIBasemapPublishServiceInstaller.ServiceName = "SOIBasemapPublish";
            this.SOIBasemapPublishServiceInstaller.AfterInstall += new System.Configuration.Install.InstallEventHandler(this.SOIBasemapPublishServiceInstaller_AfterInstall);
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.SOIBasemapPublishInstaller,
            this.SOIBasemapPublishServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller SOIBasemapPublishInstaller;
        private System.ServiceProcess.ServiceInstaller SOIBasemapPublishServiceInstaller;
    }
}