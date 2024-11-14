namespace MunicipalServiceApp
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnServiceRequest = new System.Windows.Forms.Button();
            this.btnEventsAnnounce = new System.Windows.Forms.Button();
            this.btnReportIssues = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.DarkGreen;
            this.panelSideMenu.Controls.Add(this.btnServiceRequest);
            this.panelSideMenu.Controls.Add(this.btnEventsAnnounce);
            this.panelSideMenu.Controls.Add(this.btnReportIssues);
            this.panelSideMenu.Controls.Add(this.btnHome);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(286, 553);
            this.panelSideMenu.TabIndex = 4;
            // 
            // btnServiceRequest
            // 
            this.btnServiceRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServiceRequest.FlatAppearance.BorderSize = 0;
            this.btnServiceRequest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnServiceRequest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnServiceRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceRequest.ForeColor = System.Drawing.Color.White;
            this.btnServiceRequest.Location = new System.Drawing.Point(0, 235);
            this.btnServiceRequest.Name = "btnServiceRequest";
            this.btnServiceRequest.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnServiceRequest.Size = new System.Drawing.Size(286, 45);
            this.btnServiceRequest.TabIndex = 4;
            this.btnServiceRequest.Text = "Service Request Status";
            this.btnServiceRequest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServiceRequest.UseVisualStyleBackColor = true;
            this.btnServiceRequest.Click += new System.EventHandler(this.btnServiceRequest_Click);
            // 
            // btnEventsAnnounce
            // 
            this.btnEventsAnnounce.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEventsAnnounce.FlatAppearance.BorderSize = 0;
            this.btnEventsAnnounce.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnEventsAnnounce.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnEventsAnnounce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventsAnnounce.ForeColor = System.Drawing.Color.White;
            this.btnEventsAnnounce.Location = new System.Drawing.Point(0, 190);
            this.btnEventsAnnounce.Name = "btnEventsAnnounce";
            this.btnEventsAnnounce.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEventsAnnounce.Size = new System.Drawing.Size(286, 45);
            this.btnEventsAnnounce.TabIndex = 3;
            this.btnEventsAnnounce.Text = "Local Events and Announcements";
            this.btnEventsAnnounce.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEventsAnnounce.UseVisualStyleBackColor = true;
            this.btnEventsAnnounce.Click += new System.EventHandler(this.btnEventsAnnounce_Click);
            // 
            // btnReportIssues
            // 
            this.btnReportIssues.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportIssues.FlatAppearance.BorderSize = 0;
            this.btnReportIssues.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnReportIssues.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnReportIssues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportIssues.ForeColor = System.Drawing.Color.White;
            this.btnReportIssues.Location = new System.Drawing.Point(0, 145);
            this.btnReportIssues.Name = "btnReportIssues";
            this.btnReportIssues.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReportIssues.Size = new System.Drawing.Size(286, 45);
            this.btnReportIssues.TabIndex = 2;
            this.btnReportIssues.Text = "Report Issues";
            this.btnReportIssues.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportIssues.UseVisualStyleBackColor = true;
            this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(0, 100);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(286, 45);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(286, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.Green;
            this.panelChildForm.Controls.Add(this.label1);
            this.panelChildForm.Controls.Add(this.lblLogo);
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(286, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(646, 553);
            this.panelChildForm.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(259, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Service";
            // 
            // lblLogo
            // 
            this.lblLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLogo.Location = new System.Drawing.Point(246, 377);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(181, 39);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "Municipal ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(216, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Municipal Sercive";
            this.panelSideMenu.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnServiceRequest;
        private System.Windows.Forms.Button btnEventsAnnounce;
        private System.Windows.Forms.Button btnReportIssues;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogo;
    }
}