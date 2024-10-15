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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Announcements));
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.dateFilter = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.btnAnnouncements = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
            this.buttonAll = new System.Windows.Forms.Button();
            this.listViewAnnouncements = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewRecommendations = new System.Windows.Forms.ListView();
            this.RecommendDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RecommendTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RecommendDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblRecommendations = new System.Windows.Forms.Label();
            this.panelSearch.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.Transparent;
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(800, 57);
            this.panelSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(560, 14);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 32);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.Location = new System.Drawing.Point(137, 15);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(400, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Search announcements";
            // 
            // panelFilter
            // 
            this.panelFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelFilter.BackColor = System.Drawing.Color.Transparent;
            this.panelFilter.Controls.Add(this.dateFilter);
            this.panelFilter.Controls.Add(this.comboBoxCategory);
            this.panelFilter.Controls.Add(this.btnAnnouncements);
            this.panelFilter.Controls.Add(this.btnEvents);
            this.panelFilter.Controls.Add(this.buttonAll);
            this.panelFilter.Location = new System.Drawing.Point(0, 62);
            this.panelFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(800, 60);
            this.panelFilter.TabIndex = 1;
            // 
            // dateFilter
            // 
            this.dateFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFilter.Location = new System.Drawing.Point(665, 4);
            this.dateFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateFilter.Name = "dateFilter";
            this.dateFilter.Size = new System.Drawing.Size(119, 20);
            this.dateFilter.TabIndex = 4;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(544, 2);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(103, 24);
            this.comboBoxCategory.TabIndex = 3;
            this.comboBoxCategory.Text = "Category";
            // 
            // btnAnnouncements
            // 
            this.btnAnnouncements.BackColor = System.Drawing.Color.Transparent;
            this.btnAnnouncements.FlatAppearance.BorderSize = 0;
            this.btnAnnouncements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnouncements.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnouncements.ForeColor = System.Drawing.Color.White;
            this.btnAnnouncements.Location = new System.Drawing.Point(137, 16);
            this.btnAnnouncements.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnnouncements.Name = "btnAnnouncements";
            this.btnAnnouncements.Size = new System.Drawing.Size(160, 32);
            this.btnAnnouncements.TabIndex = 2;
            this.btnAnnouncements.Text = "Announcements";
            this.btnAnnouncements.UseVisualStyleBackColor = false;
            this.btnAnnouncements.Click += new System.EventHandler(this.btnAnnouncements_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.BackColor = System.Drawing.Color.Transparent;
            this.btnEvents.FlatAppearance.BorderSize = 0;
            this.btnEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvents.ForeColor = System.Drawing.Color.White;
            this.btnEvents.Location = new System.Drawing.Point(57, 16);
            this.btnEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(88, 32);
            this.btnEvents.TabIndex = 1;
            this.btnEvents.Text = "Events";
            this.btnEvents.UseVisualStyleBackColor = false;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // buttonAll
            // 
            this.buttonAll.BackColor = System.Drawing.Color.Transparent;
            this.buttonAll.FlatAppearance.BorderSize = 0;
            this.buttonAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAll.ForeColor = System.Drawing.Color.White;
            this.buttonAll.Location = new System.Drawing.Point(3, 16);
            this.buttonAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(49, 32);
            this.buttonAll.TabIndex = 0;
            this.buttonAll.Text = "All";
            this.buttonAll.UseVisualStyleBackColor = false;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // listViewAnnouncements
            // 
            this.listViewAnnouncements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewAnnouncements.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Date,
            this.Description});
            this.listViewAnnouncements.FullRowSelect = true;
            this.listViewAnnouncements.HideSelection = false;
            this.listViewAnnouncements.Location = new System.Drawing.Point(0, 114);
            this.listViewAnnouncements.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewAnnouncements.MultiSelect = false;
            this.listViewAnnouncements.Name = "listViewAnnouncements";
            this.listViewAnnouncements.Size = new System.Drawing.Size(800, 184);
            this.listViewAnnouncements.TabIndex = 2;
            this.listViewAnnouncements.UseCompatibleStateImageBehavior = false;
            this.listViewAnnouncements.View = System.Windows.Forms.View.Details;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 150;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 120;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 300;
            // 
            // listViewRecommendations
            // 
            this.listViewRecommendations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewRecommendations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RecommendDate,
            this.RecommendTitle,
            this.RecommendDescription});
            this.listViewRecommendations.HideSelection = false;
            this.listViewRecommendations.Location = new System.Drawing.Point(0, 325);
            this.listViewRecommendations.Margin = new System.Windows.Forms.Padding(4);
            this.listViewRecommendations.Name = "listViewRecommendations";
            this.listViewRecommendations.Size = new System.Drawing.Size(326, 125);
            this.listViewRecommendations.TabIndex = 3;
            this.listViewRecommendations.UseCompatibleStateImageBehavior = false;
            this.listViewRecommendations.View = System.Windows.Forms.View.List;
            // 
            // RecommendDate
            // 
            this.RecommendDate.Text = "Date";
            this.RecommendDate.Width = 200;
            // 
            // RecommendTitle
            // 
            this.RecommendTitle.Text = "Title";
            this.RecommendTitle.Width = 200;
            // 
            // RecommendDescription
            // 
            this.RecommendDescription.Text = "Description";
            this.RecommendDescription.Width = 200;
            // 
            // lblRecommendations
            // 
            this.lblRecommendations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecommendations.AutoSize = true;
            this.lblRecommendations.BackColor = System.Drawing.Color.Transparent;
            this.lblRecommendations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecommendations.ForeColor = System.Drawing.Color.Black;
            this.lblRecommendations.Location = new System.Drawing.Point(-1, 302);
            this.lblRecommendations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecommendations.Name = "lblRecommendations";
            this.lblRecommendations.Size = new System.Drawing.Size(114, 17);
            this.lblRecommendations.TabIndex = 4;
            this.lblRecommendations.Text = "Recommended";
            // 
            // Announcements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRecommendations);
            this.Controls.Add(this.listViewRecommendations);
            this.Controls.Add(this.listViewAnnouncements);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Announcements";
            this.Text = "Local Events and Announcements";
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ListView listViewAnnouncements;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ListView listViewRecommendations;
        private System.Windows.Forms.Label lblRecommendations;
        private System.Windows.Forms.ColumnHeader RecommendDate;
        private System.Windows.Forms.ColumnHeader RecommendTitle;
        private System.Windows.Forms.ColumnHeader RecommendDescription;
    }
}