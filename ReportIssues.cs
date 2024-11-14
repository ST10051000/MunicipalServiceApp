using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MunicipalServiceApp
{
    public partial class ReportIssues : Form
    {
        Homepage homepage = new Homepage();

        /// <summary>
        /// List that stores the report input
        /// </summary>
        public static List<ReportsClass> reportInputList = new List<ReportsClass>();

        /// <summary>
        /// Variable that stores image file path
        /// </summary>
        private string imagePath;

        public ReportIssues()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This button allows the user to search and add an attachment
        /// (OpenAI, 2024)
        /// https://chatgpt.com/share/66ea0923-e8e0-8012-8c9a-54a226bcf771
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAttach_Click(object sender, EventArgs e)
        {
            // Create a new instance of OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the title of the dialog
            openFileDialog.Title = "Attach Media (Images or Documents)";

            // Filter file types (for example, image and document types)
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png|Document Files (*.pdf; *.docx)|*.pdf;*.docx";

            // Allow multiple file selection (if true)
            openFileDialog.Multiselect = false;  

            // Show the dialog and check if the user selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file's full path
                imagePath = openFileDialog.FileName;

                // Display the file name in a label
                lblImagePath.Text = imagePath;

                // Load the image into the PictureBox to display it
                pictureBox1.Image = Image.FromFile(imagePath);

                // Optionally, set the PictureBox size mode to better display the image
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                UpdateProgressBar();
                lblProgress.Text = "You did it!";
            }
        }

        /// <summary>
        /// This button will save all the user input to a list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(txtLocation.Text) ||
                string.IsNullOrWhiteSpace(cmboCategory.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                // Message if a field is empty
                MessageBox.Show("Fields can't be empty!", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ensures that user has attached an image or document
            if (string.IsNullOrEmpty(imagePath))
            {
                // Message if user doesn't add an atachment
                MessageBox.Show("Please attach an image or document", "Missing Attachment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Collecting user input
            ReportsClass reportData = new ReportsClass
            {
                Location = txtLocation.Text,  
                Category = cmboCategory.Text,
                Description = txtDescription.Text,
                ImagePath = imagePath,
            };

            // Add data to the list
            reportInputList.Add(reportData);

            // Clearing all the fields for new data
            txtLocation.Clear();
            txtDescription.Clear();
            pictureBox1.Image = null;
            lblImagePath.Text = "";
            cmboCategory.SelectedIndex = -1;
            progressBar1.Value = 0;
            lblProgress.Text = "Let's Get Started!";

            // Success message
            MessageBox.Show("We've got your report!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        /// <summary>
        /// This button will take the user to the reports form 
        /// that displays all the reports the user has entered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReports_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.MdiParent = this.MdiParent;  
            reports.Show();
            this.Close(); // Close the current form
        }

        /// <summary>
        /// This method updates the progress bar as the user fills in the form
        /// (OpenAI, 2024)
        /// https://chatgpt.com/share/66ea0cac-e000-8012-8001-2ff5c2a19073
        /// </summary>
        private void UpdateProgressBar()
        {
            int progress = 0;

            if (!string.IsNullOrWhiteSpace(txtLocation.Text))
                progress += 25;  // 25% for location

            if (!string.IsNullOrWhiteSpace(cmboCategory.Text))
                progress += 25;  // 25% for category

            if (!string.IsNullOrWhiteSpace(txtDescription.Text))
                progress += 25;  // 25% for description

            if (!string.IsNullOrEmpty(imagePath))
                progress += 25;  // 25% for attached image

            progressBar1.Value = progress;  // Update progress
        }

        /// <summary>
        /// Calls the method that updates the progress bar 
        /// and displays a motivational message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
            lblProgress.Text = "Let's go!";
        }

        /// <summary>
        /// Calls the method that updates the progress bar 
        /// and displays a motivational message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
            lblProgress.Text = "Half way done!";
        }

        /// <summary>
        /// Calls the method that updates the progress bar 
        /// and displays a motivational message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
            lblProgress.Text = "Good job! One more step.";
        }
    }
}
