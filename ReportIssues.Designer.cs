namespace MunicipalServiceApp
{
    partial class ReportIssues
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportIssues));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblAttachment = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.cmboCategory = new System.Windows.Forms.ComboBox();
            this.btnAttach = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblImagePath = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Green;
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.tableLayoutPanel1.Controls.Add(this.lblLocation, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCategory, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDescription, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblAttachment, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtDescription, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmboCategory, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAttach, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblProgress, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblImagePath, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnSubmit, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtLocation, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblHeading, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(628, 506);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.Color.White;
            this.lblLocation.Location = new System.Drawing.Point(4, 56);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(75, 17);
            this.lblLocation.TabIndex = 0;
            this.lblLocation.Text = "Location:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(4, 96);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(78, 17);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(4, 154);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(95, 17);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description:";
            // 
            // lblAttachment
            // 
            this.lblAttachment.AutoSize = true;
            this.lblAttachment.BackColor = System.Drawing.Color.Transparent;
            this.lblAttachment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttachment.ForeColor = System.Drawing.Color.White;
            this.lblAttachment.Location = new System.Drawing.Point(4, 253);
            this.lblAttachment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttachment.Name = "lblAttachment";
            this.lblAttachment.Size = new System.Drawing.Size(94, 17);
            this.lblAttachment.TabIndex = 3;
            this.lblAttachment.Text = "Attachment:";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(135, 156);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(144, 95);
            this.txtDescription.TabIndex = 8;
            this.txtDescription.Text = "";
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // cmboCategory
            // 
            this.cmboCategory.BackColor = System.Drawing.Color.White;
            this.cmboCategory.FormattingEnabled = true;
            this.cmboCategory.Items.AddRange(new object[] {
            "Sanitation",
            "Roads ",
            "Utilities",
            "Other"});
            this.cmboCategory.Location = new System.Drawing.Point(135, 98);
            this.cmboCategory.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cmboCategory.Name = "cmboCategory";
            this.cmboCategory.Size = new System.Drawing.Size(144, 28);
            this.cmboCategory.TabIndex = 11;
            this.cmboCategory.SelectedIndexChanged += new System.EventHandler(this.cmboCategory_SelectedIndexChanged);
            // 
            // btnAttach
            // 
            this.btnAttach.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAttach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAttach.FlatAppearance.BorderSize = 0;
            this.btnAttach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttach.ForeColor = System.Drawing.Color.White;
            this.btnAttach.Location = new System.Drawing.Point(135, 255);
            this.btnAttach.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(144, 42);
            this.btnAttach.TabIndex = 9;
            this.btnAttach.Text = "Attach File";
            this.btnAttach.UseVisualStyleBackColor = false;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(135, 306);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 108);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.ForeColor = System.Drawing.Color.DarkGreen;
            this.progressBar1.Location = new System.Drawing.Point(404, 58);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(195, 29);
            this.progressBar1.TabIndex = 12;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.BackColor = System.Drawing.Color.Transparent;
            this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.ForeColor = System.Drawing.Color.White;
            this.lblProgress.Location = new System.Drawing.Point(405, 96);
            this.lblProgress.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(136, 17);
            this.lblProgress.TabIndex = 17;
            this.lblProgress.Text = "Let\'s Get Started!";
            // 
            // lblImagePath
            // 
            this.lblImagePath.AutoSize = true;
            this.lblImagePath.ForeColor = System.Drawing.Color.White;
            this.lblImagePath.Location = new System.Drawing.Point(404, 304);
            this.lblImagePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImagePath.Name = "lblImagePath";
            this.lblImagePath.Size = new System.Drawing.Size(21, 20);
            this.lblImagePath.TabIndex = 18;
            this.lblImagePath.Text = "...";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(135, 438);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(144, 48);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.Color.White;
            this.txtLocation.Location = new System.Drawing.Point(135, 58);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtLocation.Multiline = true;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(144, 21);
            this.txtLocation.TabIndex = 6;
            this.txtLocation.TextChanged += new System.EventHandler(this.txtLocation_TextChanged);
            // 
            // lblHeading
            // 
            this.lblHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(197, 15);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(137, 24);
            this.lblHeading.TabIndex = 19;
            this.lblHeading.Text = "Report Issues";
            // 
            // ReportIssues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(628, 506);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "ReportIssues";
            this.Text = "Report Issues";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAttachment;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.ComboBox cmboCategory;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblImagePath;
        private System.Windows.Forms.Label lblHeading;
    }
}