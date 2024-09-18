namespace MunicipalServiceApp
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.btnRequestServ = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
            this.btnReportIssues = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRequestServ
            // 
            this.btnRequestServ.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRequestServ.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRequestServ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRequestServ.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestServ.ForeColor = System.Drawing.Color.White;
            this.btnRequestServ.Location = new System.Drawing.Point(545, 119);
            this.btnRequestServ.Name = "btnRequestServ";
            this.btnRequestServ.Size = new System.Drawing.Size(217, 135);
            this.btnRequestServ.TabIndex = 3;
            this.btnRequestServ.Text = "REQUEST SERVICES";
            this.btnRequestServ.UseVisualStyleBackColor = false;
            this.btnRequestServ.Click += new System.EventHandler(this.btnRequestServ_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEvents.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEvents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEvents.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvents.ForeColor = System.Drawing.Color.White;
            this.btnEvents.Location = new System.Drawing.Point(215, 290);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(369, 138);
            this.btnEvents.TabIndex = 2;
            this.btnEvents.Text = "EVENTS AND ANNOUNCEMENTS";
            this.btnEvents.UseVisualStyleBackColor = false;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // btnReportIssues
            // 
            this.btnReportIssues.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnReportIssues.BackColor = System.Drawing.Color.ForestGreen;
            this.btnReportIssues.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReportIssues.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportIssues.ForeColor = System.Drawing.Color.White;
            this.btnReportIssues.Location = new System.Drawing.Point(42, 119);
            this.btnReportIssues.Name = "btnReportIssues";
            this.btnReportIssues.Size = new System.Drawing.Size(217, 135);
            this.btnReportIssues.TabIndex = 1;
            this.btnReportIssues.Text = "REPORT ISSUES";
            this.btnReportIssues.UseVisualStyleBackColor = false;
            this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 87);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEvents);
            this.Controls.Add(this.btnRequestServ);
            this.Controls.Add(this.btnReportIssues);
            this.Name = "HomePage";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRequestServ;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button btnReportIssues;
        private System.Windows.Forms.Label label1;
    }
}