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
    public partial class ServiceRequests : Form
    {
        // Field to hold the reference to the shared ServiceRequestManager instance.
        private ServiceRequestManager manager;

        /// <summary>
        /// Constructor accepting a ServiceRequestManager instance for data sharing.
        /// </summary>
        /// <param name="serviceRequestManager"></param>
        public ServiceRequests(ServiceRequestManager serviceRequestManager)
        {
            InitializeComponent();
            manager = serviceRequestManager; // Assign the shared manager instance.
            BindDataToGrid(manager.GetAllRequests()); // Load and display all service requests in the grid.
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Adding sample data
        /// </summary>
        private void LoadSampleData()
        {
            manager.AddRequest(new ServiceRequestClass { ID = 4, Category = "Road Maintenance", Location = "Industrial Zone, Town D", Status = "Completed", DateRequested = DateTime.Now.AddDays(-2) });
            manager.AddRequest(new ServiceRequestClass { ID = 1, Category = "Water", Location = "Main Street, Town A", Status = "Pending", DateRequested = DateTime.Now.AddDays(-5) });
            manager.AddRequest(new ServiceRequestClass { ID = 2, Category = "Electricity", Location = "Highway Avenue, Town B", Status = "In Progress", DateRequested = DateTime.Now.AddDays(-10) });
            manager.AddRequest(new ServiceRequestClass { ID = 3, Category = "Waste Management", Location = "Green Park, Town C", Status = "Completed", DateRequested = DateTime.Now.AddDays(-15) });
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Method binds a list of service requests to the DataGridView for display.
        /// </summary>
        /// <param name="data"></param>
        public void BindDataToGrid(List<ServiceRequestClass> data)
        {
            // Displays a message if there is no data.
            if (data == null || data.Count == 0)
            {
                MessageBox.Show("No data available to display.");
                dataGridViewRequests.DataSource = null;
            }
            // Else reset and bind the new data to the DataGridView.
            else
            {
                dataGridViewRequests.DataSource = null; // Reset the grid
                dataGridViewRequests.DataSource = new BindingList<ServiceRequestClass>(data); // Bind new data

                // Hiding unwanted columns
                foreach (DataGridViewColumn column in dataGridViewRequests.Columns)
                {
                    if (column.Name != "ID" && column.Name != "Category" && column.Name != "Location" && column.Name != "Status")
                    {
                        column.Visible = false;
                    }
                }
            }
        }

        /// <summary>
        /// Method refreshes the data displayed in the DataGridView 
        /// by reloading all service requests.
        /// </summary>
        public void RefreshDataGrid()
        {
            BindDataToGrid(manager.GetAllRequests());
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Button with event handlers to search for an issue 
        /// with a specific ID.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txtSearch.Text, out id))
            {
                ServiceRequestClass request = manager.SearchById(id);
                if (request != null)
                {
                    // Message that displays if it is found. 
                    MessageBox.Show($"Found: Request #{request.ID} \nCategory: {request.Category} \nLocation: {request.Location} \nStatus: {request.Status}");
                }
                else
                {
                    // Message that displays if no request is found.
                    MessageBox.Show("Request not found!");
                }
            }
            else
            {
                // Message that displays if the input is invalid.
                MessageBox.Show("Please enter a valid ID.");
            }
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Button that sorts the data according to its status.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSort_Click(object sender, EventArgs e)
        {
            // Retrieve service requests sorted by status.
            var sortedRequests = manager.GetSortedByStatus();

            // Bind sorted data to grid.
            BindDataToGrid(sortedRequests);  
        }

        //----------------------------------------------------------------------------------------------------------------------------------
        private void dataGridViewRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure a row is selected
            if (dataGridViewRequests.SelectedRows.Count > 0)
            {
                // Get the selected ServiceRequestClass object
                var selectedRequest = dataGridViewRequests.SelectedRows[0].DataBoundItem as ServiceRequestClass;
                if (selectedRequest != null)
                {
                    // Set the ComboBox to the current status of the selected request
                    comboBoxStatus.SelectedItem = selectedRequest.Status;
                }
            }
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        private void btnStatusUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewRequests.SelectedRows.Count > 0)
            {
                // Get the selected ServiceRequestClass object
                var selectedRequest = dataGridViewRequests.SelectedRows[0].DataBoundItem as ServiceRequestClass;
                if (selectedRequest != null && comboBoxStatus.SelectedItem != null)
                {
                    // Update the status of the selected request
                    selectedRequest.Status = comboBoxStatus.SelectedItem.ToString();

                    // Save the update to the manager
                    manager.UpdateRequest(selectedRequest);

                    // Refresh the DataGridView
                    RefreshDataGrid();
                    MessageBox.Show($"Status updated to '{selectedRequest.Status}' for Request #{selectedRequest.ID}");
                }
                else
                {
                    MessageBox.Show("Please select a valid status.");
                }
            }
            else
            {
                MessageBox.Show("No request selected.");
            }
        }
    }
}
//-------------------------------------------------------------THE END----------------------------------------------------------------------
