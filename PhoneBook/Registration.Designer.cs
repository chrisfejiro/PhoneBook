namespace PhoneBook
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNewData = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.gbInfoBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbCellNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.gbInfoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripSeparator3,
            this.tsbNewData,
            this.toolStripSeparator2,
            this.tsbSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(582, 71);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNewData
            // 
            this.tsbNewData.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewData.Image")));
            this.tsbNewData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewData.Name = "tsbNewData";
            this.tsbNewData.Size = new System.Drawing.Size(117, 66);
            this.tsbNewData.Text = "New Data";
            this.tsbNewData.Click += new System.EventHandler(this.tsbNewData_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.Enabled = false;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(150, 66);
            this.tsbSave.Text = "Save Changes";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 71);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 71);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 71);
            // 
            // gbInfoBox
            // 
            this.gbInfoBox.Controls.Add(this.tbFirstName);
            this.gbInfoBox.Controls.Add(this.label8);
            this.gbInfoBox.Controls.Add(this.tbLastName);
            this.gbInfoBox.Controls.Add(this.label7);
            this.gbInfoBox.Controls.Add(this.tbTelephone);
            this.gbInfoBox.Controls.Add(this.label6);
            this.gbInfoBox.Controls.Add(this.tbComment);
            this.gbInfoBox.Controls.Add(this.label5);
            this.gbInfoBox.Controls.Add(this.tbAddress);
            this.gbInfoBox.Controls.Add(this.label4);
            this.gbInfoBox.Controls.Add(this.tbEmail);
            this.gbInfoBox.Controls.Add(this.label3);
            this.gbInfoBox.Controls.Add(this.tbCellNumber);
            this.gbInfoBox.Controls.Add(this.label2);
            this.gbInfoBox.Controls.Add(this.tbId);
            this.gbInfoBox.Controls.Add(this.label1);
            this.gbInfoBox.Enabled = false;
            this.gbInfoBox.Location = new System.Drawing.Point(12, 74);
            this.gbInfoBox.Name = "gbInfoBox";
            this.gbInfoBox.Size = new System.Drawing.Size(558, 506);
            this.gbInfoBox.TabIndex = 1;
            this.gbInfoBox.TabStop = false;
            this.gbInfoBox.Text = "Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(116, 41);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(367, 26);
            this.tbId.TabIndex = 1;
            // 
            // tbCellNumber
            // 
            this.tbCellNumber.Location = new System.Drawing.Point(114, 253);
            this.tbCellNumber.Name = "tbCellNumber";
            this.tbCellNumber.Size = new System.Drawing.Size(369, 26);
            this.tbCellNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cell Number:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(114, 308);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(369, 26);
            this.tbEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address:";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(116, 364);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(367, 26);
            this.tbAddress.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Comment:";
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(116, 422);
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(367, 26);
            this.tbComment.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email:";
            // 
            // tbTelephone
            // 
            this.tbTelephone.Location = new System.Drawing.Point(114, 199);
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(369, 26);
            this.tbTelephone.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telephone:";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(116, 147);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(367, 26);
            this.tbLastName.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Last Name:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(116, 98);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(367, 26);
            this.tbFirstName.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "First Name:";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(582, 659);
            this.Controls.Add(this.gbInfoBox);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register_Data";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbInfoBox.ResumeLayout(false);
            this.gbInfoBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbNewData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.GroupBox gbInfoBox;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTelephone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCellNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label1;
    }
}