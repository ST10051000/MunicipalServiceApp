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
            this.SuspendLayout();
            // 
            // btnRequestServ
            // 
            this.btnRequestServ.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRequestServ.BackColor = System.Drawing.Color.LightGray;
            this.btnRequestServ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRequestServ.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestServ.ForeColor = System.Drawing.Color.Black;
            this.btnRequestServ.Location = new System.Drawing.Point(225, 266);
            this.btnRequestServ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRequestServ.Name = "btnRequestServ";
            this.btnRequestServ.Size = new System.Drawing.Size(196, 58);
            this.btnRequestServ.TabIndex = 3;
            this.btnRequestServ.Text = "REQUEST SERVICES";
            this.btnRequestServ.UseVisualStyleBackColor = false;
            this.btnRequestServ.Click += new System.EventHandler(this.btnRequestServ_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEvents.BackColor = System.Drawing.Color.LightGray;
            this.btnEvents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEvents.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvents.ForeColor = System.Drawing.Color.Black;
            this.btnEvents.Location = new System.Drawing.Point(225, 161);
            this.btnEvents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(196, 58);
            this.btnEvents.TabIndex = 2;
            this.btnEvents.Text = "EVENTS AND ANNOUNCEMENTS";
            this.btnEvents.UseVisualStyleBackColor = false;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // btnReportIssues
            // 
            this.btnReportIssues.BackColor = System.Drawing.Color.LightGray;
            this.btnReportIssues.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReportIssues.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportIssues.ForeColor = System.Drawing.Color.Black;
            this.btnReportIssues.Location = new System.Drawing.Point(225, 66);
            this.btnReportIssues.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReportIssues.Name = "btnReportIssues";
            this.btnReportIssues.Size = new System.Drawing.Size(196, 58);
            this.btnReportIssues.TabIndex = 1;
            this.btnReportIssues.Text = "REPORT ISSUES";
            this.btnReportIssues.UseVisualStyleBackColor = false;
            this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnEvents);
            this.Controls.Add(this.btnRequestServ);
            this.Controls.Add(this.btnReportIssues);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRequestServ;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button btnReportIssues;
    }
}