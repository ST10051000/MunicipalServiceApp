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
    public partial class Homepage : Form
    {
        // Shared ServiceRequestManager instance
        private ServiceRequestManager serviceRequestManager = new ServiceRequestManager(); 

        /// <summary>
        /// Constructor
        /// </summary>
        public Homepage()
        {
            InitializeComponent();
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        // Tracks the currently active child form.
        private Form activeForm = null;

        /// <summary>
        /// Method opens a child form inside a designated panel on the homepage.
        /// </summary>
        /// <param name="childForm"></param>
        private void openChildFormInPanel(Form childForm)
        {
            // Close the currently active child form
            if (activeForm != null)
                activeForm.Close();

            // Setting the new child form as the active form.
            activeForm = childForm;

            // Configuring the child form to be displayed within the panel.
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Adding the child form to the panel and associate it with the panel.
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;

            // Bringing the child form to the front and displaying it.
            childForm.BringToFront();
            childForm.Show();
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Button to close the active form to return to the homepage view.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
        }

        /// <summary>
        /// Button that opens the ReportIssues form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            // Pass the shared manager to ReportIssues
            openChildFormInPanel(new ReportIssues(serviceRequestManager));
        }

        /// <summary>
        /// Button that opens the Announcements form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEventsAnnounce_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Announcements());
        }

        /// <summary>
        /// Button that opens the ServiceRequests form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnServiceRequest_Click(object sender, EventArgs e)
        {
            // Pass the shared manager to ServiceRequests
            openChildFormInPanel(new ServiceRequests(serviceRequestManager));
        }
    }
}

//-------------------------------------------------------------THE END----------------------------------------------------------------------
// (RJ Code Advance, 2019)
// https://www.youtube.com/watch?v=JP5rgXO_5Sk
// Video of how to get this layout and navigate to different forms.
