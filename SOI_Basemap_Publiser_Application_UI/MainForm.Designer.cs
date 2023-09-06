namespace SOI_Basemap_Publiser_Application_UI
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pctApplicationIcon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServiceStatus = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.ntfySOIBasemap = new System.Windows.Forms.NotifyIcon(this.components);
            this.cntxtSOIBasemapMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showControllerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitControllerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pctApplicationIcon)).BeginInit();
            this.cntxtSOIBasemapMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctApplicationIcon
            // 
            this.pctApplicationIcon.Image = ((System.Drawing.Image)(resources.GetObject("pctApplicationIcon.Image")));
            this.pctApplicationIcon.Location = new System.Drawing.Point(1, 1);
            this.pctApplicationIcon.Name = "pctApplicationIcon";
            this.pctApplicationIcon.Size = new System.Drawing.Size(36, 31);
            this.pctApplicationIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctApplicationIcon.TabIndex = 0;
            this.pctApplicationIcon.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "SOI Basemap Publisher Service Controller";
            // 
            // txtServiceStatus
            // 
            this.txtServiceStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtServiceStatus.Enabled = false;
            this.txtServiceStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceStatus.Location = new System.Drawing.Point(44, 48);
            this.txtServiceStatus.Name = "txtServiceStatus";
            this.txtServiceStatus.Size = new System.Drawing.Size(347, 22);
            this.txtServiceStatus.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(44, 74);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(118, 32);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(168, 74);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(111, 32);
            this.btnRestart.TabIndex = 4;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(285, 74);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(106, 32);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // ntfySOIBasemap
            // 
            this.ntfySOIBasemap.Text = "SOI Basemap Publisher";
            this.ntfySOIBasemap.Visible = true;
            // 
            // cntxtSOIBasemapMenuStrip
            // 
            this.cntxtSOIBasemapMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showControllerToolStripMenuItem,
            this.quitControllerToolStripMenuItem});
            this.cntxtSOIBasemapMenuStrip.Name = "cntxtSOIBasemapMenuStrip";
            this.cntxtSOIBasemapMenuStrip.Size = new System.Drawing.Size(160, 48);
            // 
            // showControllerToolStripMenuItem
            // 
            this.showControllerToolStripMenuItem.Name = "showControllerToolStripMenuItem";
            this.showControllerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showControllerToolStripMenuItem.Text = "Show Controller";
            this.showControllerToolStripMenuItem.Click += new System.EventHandler(this.showControllerToolStripMenuItem_Click);
            // 
            // quitControllerToolStripMenuItem
            // 
            this.quitControllerToolStripMenuItem.Name = "quitControllerToolStripMenuItem";
            this.quitControllerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitControllerToolStripMenuItem.Text = "Quit Controller";
            this.quitControllerToolStripMenuItem.Click += new System.EventHandler(this.quitControllerToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(417, 118);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtServiceStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctApplicationIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SOI Basemap Publisher Service Controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctApplicationIcon)).EndInit();
            this.cntxtSOIBasemapMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctApplicationIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServiceStatus;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.NotifyIcon ntfySOIBasemap;
        private System.Windows.Forms.ContextMenuStrip cntxtSOIBasemapMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showControllerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitControllerToolStripMenuItem;
    }
}

