namespace PhoneBook
{
    partial class ContactDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactDetails));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbRegisterData = new System.Windows.Forms.ToolStripButton();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbCalculator = new System.Windows.Forms.ToolStripButton();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.calcProcess = new System.Diagnostics.Process();
            this.tbsAboutUs = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRegisterData,
            this.tsbSearch,
            this.tsbCalculator,
            this.tsbExit,
            this.tbsAboutUs});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(987, 73);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbRegisterData
            // 
            this.tsbRegisterData.Image = ((System.Drawing.Image)(resources.GetObject("tsbRegisterData.Image")));
            this.tsbRegisterData.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRegisterData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRegisterData.Name = "tsbRegisterData";
            this.tsbRegisterData.Size = new System.Drawing.Size(177, 68);
            this.tsbRegisterData.Text = "Register Data F2";
            this.tsbRegisterData.ToolTipText = "RegisterData ";
            this.tsbRegisterData.Click += new System.EventHandler(this.tsbRegisterData_Click);
            // 
            // tsbSearch
            // 
            this.tsbSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearch.Image")));
            this.tsbSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(124, 68);
            this.tsbSearch.Text = "Search F3";
            this.tsbSearch.ToolTipText = "Search ";
            this.tsbSearch.Click += new System.EventHandler(this.tsbSearch_Click);
            // 
            // tsbCalculator
            // 
            this.tsbCalculator.Image = ((System.Drawing.Image)(resources.GetObject("tsbCalculator.Image")));
            this.tsbCalculator.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCalculator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCalculator.Name = "tsbCalculator";
            this.tsbCalculator.Size = new System.Drawing.Size(142, 68);
            this.tsbCalculator.Text = "Calculator F4";
            this.tsbCalculator.ToolTipText = "Calculator";
            this.tsbCalculator.Click += new System.EventHandler(this.tsbCalculator_Click);
            // 
            // tsbExit
            // 
            this.tsbExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbExit.Image")));
            this.tsbExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(120, 68);
            this.tsbExit.Text = "Exit (ESC)";
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // calcProcess
            // 
            this.calcProcess.StartInfo.Domain = "";
            this.calcProcess.StartInfo.LoadUserProfile = false;
            this.calcProcess.StartInfo.Password = null;
            this.calcProcess.StartInfo.StandardErrorEncoding = null;
            this.calcProcess.StartInfo.StandardOutputEncoding = null;
            this.calcProcess.StartInfo.UserName = "";
            this.calcProcess.SynchronizingObject = this;
            // 
            // tbsAboutUs
            // 
            this.tbsAboutUs.Image = ((System.Drawing.Image)(resources.GetObject("tbsAboutUs.Image")));
            this.tbsAboutUs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsAboutUs.Name = "tbsAboutUs";
            this.tbsAboutUs.Size = new System.Drawing.Size(139, 68);
            this.tbsAboutUs.Text = "About Us F5";
            this.tbsAboutUs.Click += new System.EventHandler(this.tbsAboutUs_Click);
            // 
            // ContactDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(987, 652);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "ContactDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbRegisterData;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripButton tsbCalculator;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ToolStripButton tsbAboutUs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Diagnostics.Process calcProcess;
        private System.Windows.Forms.ToolStripButton tsbAboutUss;
        private System.Windows.Forms.ToolStripButton tbsAboutUs;
    }
}

