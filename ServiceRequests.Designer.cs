namespace MunicipalServiceApp
{
    partial class ServiceRequests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceRequests));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewRequests = new System.Windows.Forms.DataGridView();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.btnStatusUpdate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequests)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridViewRequests);
            this.panel1.Controls.Add(this.panelSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 623);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewRequests
            // 
            this.dataGridViewRequests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRequests.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequests.Location = new System.Drawing.Point(35, 157);
            this.dataGridViewRequests.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewRequests.Name = "dataGridViewRequests";
            this.dataGridViewRequests.RowHeadersWidth = 51;
            this.dataGridViewRequests.RowTemplate.Height = 24;
            this.dataGridViewRequests.Size = new System.Drawing.Size(764, 376);
            this.dataGridViewRequests.TabIndex = 4;
            this.dataGridViewRequests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRequests_CellContentClick);
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.Transparent;
            this.panelSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Controls.Add(this.btnSort);
            this.panelSearch.Controls.Add(this.lblHeading);
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(837, 153);
            this.panelSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.Location = new System.Drawing.Point(482, 64);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 27);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(35, 112);
            this.btnSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 30);
            this.btnSort.TabIndex = 3;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(311, 25);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(238, 25);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Service Request Status";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.Location = new System.Drawing.Point(271, 66);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(159, 22);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Search ID";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnStatusUpdate);
            this.panel2.Controls.Add(this.comboBoxStatus);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 550);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(837, 73);
            this.panel2.TabIndex = 5;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Pending",
            "In Progress",
            "Complete"});
            this.comboBoxStatus.Location = new System.Drawing.Point(562, 22);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 24);
            this.comboBoxStatus.TabIndex = 0;
            // 
            // btnStatusUpdate
            // 
            this.btnStatusUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStatusUpdate.Location = new System.Drawing.Point(724, 23);
            this.btnStatusUpdate.Name = "btnStatusUpdate";
            this.btnStatusUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnStatusUpdate.TabIndex = 1;
            this.btnStatusUpdate.Text = "Update";
            this.btnStatusUpdate.UseVisualStyleBackColor = true;
            this.btnStatusUpdate.Click += new System.EventHandler(this.btnStatusUpdate_Click);
            // 
            // ServiceRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(837, 623);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ServiceRequests";
            this.Text = "Service Requests";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequests)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridViewRequests;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStatusUpdate;
        private System.Windows.Forms.ComboBox comboBoxStatus;
    }
}