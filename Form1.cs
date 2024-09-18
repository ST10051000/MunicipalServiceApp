using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalServiceApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Takes the user to the reports form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportIssues reports = new ReportIssues();
            reports.MdiParent = this;
            reports.Show();
        }

        /// <summary>
        /// Takes the user to the announcements form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void localEventsAndAnnouncementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Announcements announcements = new Announcements();
            announcements.MdiParent = this;
            announcements.Show();
        }

        /// <summary>
        /// Takes the user to the service requests form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serviceRequestStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceRequests requests = new ServiceRequests();
            requests.MdiParent = this;
            requests.Show();
        }

        /// <summary>
        /// Takes the user to the reports form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.MdiParent = this;  
            reports.Show();
        }

        /// <summary>
        /// Takes the user to the homepage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage();
            homepage.MdiParent = this;
            homepage.Show();
        }

        /// <summary>
        /// Makes sure the homepage opens on startup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.MdiParent = this;
            homePage.Show();
        }
    }     
}
