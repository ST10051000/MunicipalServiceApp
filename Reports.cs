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

namespace MunicipalServiceApp
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method displays the user input and the attatchment
        /// (OpenAI, 2024)
        /// https://chatgpt.com/share/66ea0923-e8e0-8012-8c9a-54a226bcf771
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reports_Load(object sender, EventArgs e)
        {
            // Access the static list from ChildForm1 and display the data
            foreach (var input in ReportIssues.reportInputList)
            {
                listBox1.Items.Add($"Location: {input.Location}, Category: {input.Category}, Description: {input.Description}");

                // Check if the image path exists and the file is valid
                if (!string.IsNullOrEmpty(input.ImagePath) && File.Exists(input.ImagePath))
                {
                    // Create a new PictureBox to display the image
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = Image.FromFile(input.ImagePath);

                    // Set PictureBox size and display settings
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Height = 100;  // Adjust height as needed
                    pictureBox.Width = 100;   // Adjust width as needed

                    // Add the PictureBox to the form dynamically (for example, to a FlowLayoutPanel or other container)
                    flowLayoutPanel1.Controls.Add(pictureBox);  
                }
            }
        }
    }
}
