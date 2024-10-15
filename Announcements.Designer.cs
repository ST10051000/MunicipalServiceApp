namespace MunicipalServiceApp
{
    partial class Announcements
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
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.dateFilter = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.btnAnnouncements = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
            this.buttonAll = new System.Windows.Forms.Button();
            this.dataGridAnnouncements = new System.Windows.Forms.DataGridView();
            this.panelSearch.SuspendLayout();
            this.panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAnnouncements)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(800, 60);
            this.panelSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(572, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.Location = new System.Drawing.Point(137, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(400, 22);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Search announcements";
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(this.dateFilter);
            this.panelFilter.Controls.Add(this.comboBoxCategory);
            this.panelFilter.Controls.Add(this.btnAnnouncements);
            this.panelFilter.Controls.Add(this.btnEvents);
            this.panelFilter.Controls.Add(this.buttonAll);
            this.panelFilter.Location = new System.Drawing.Point(0, 66);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(800, 42);
            this.panelFilter.TabIndex = 1;
            // 
            // dateFilter
            // 
            this.dateFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFilter.Location = new System.Drawing.Point(653, 4);
            this.dateFilter.Name = "dateFilter";
            this.dateFilter.Size = new System.Drawing.Size(119, 22);
            this.dateFilter.TabIndex = 4;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(559, 3);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(88, 24);
            this.comboBoxCategory.TabIndex = 3;
            this.comboBoxCategory.Text = "Category";
            // 
            // btnAnnouncements
            // 
            this.btnAnnouncements.Location = new System.Drawing.Point(230, 3);
            this.btnAnnouncements.Name = "btnAnnouncements";
            this.btnAnnouncements.Size = new System.Drawing.Size(121, 23);
            this.btnAnnouncements.TabIndex = 2;
            this.btnAnnouncements.Text = "Announcements";
            this.btnAnnouncements.UseVisualStyleBackColor = true;
            this.btnAnnouncements.Click += new System.EventHandler(this.btnAnnouncements_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.Location = new System.Drawing.Point(149, 3);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(75, 23);
            this.btnEvents.TabIndex = 1;
            this.btnEvents.Text = "Events";
            this.btnEvents.UseVisualStyleBackColor = true;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // buttonAll
            // 
            this.buttonAll.Location = new System.Drawing.Point(68, 3);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(75, 23);
            this.buttonAll.TabIndex = 0;
            this.buttonAll.Text = "All";
            this.buttonAll.UseVisualStyleBackColor = true;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // dataGridAnnouncements
            // 
            this.dataGridAnnouncements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAnnouncements.Location = new System.Drawing.Point(0, 114);
            this.dataGridAnnouncements.Name = "dataGridAnnouncements";
            this.dataGridAnnouncements.RowHeadersWidth = 51;
            this.dataGridAnnouncements.RowTemplate.Height = 24;
            this.dataGridAnnouncements.Size = new System.Drawing.Size(800, 337);
            this.dataGridAnnouncements.TabIndex = 2;
            // 
            // Announcements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridAnnouncements);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Announcements";
            this.Text = "Local Events and Announcements";
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAnnouncements)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button btnAnnouncements;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.DateTimePicker dateFilter;
        private System.Windows.Forms.DataGridView dataGridAnnouncements;
    }
}