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
        public Homepage()
        {
            InitializeComponent();
        }

        private Form activeForm = null;

        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ReportIssues());
        }

        private void btnEventsAnnounce_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Announcements());
        }

        private void btnServiceRequest_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ServiceRequests());
        }
    }
}
