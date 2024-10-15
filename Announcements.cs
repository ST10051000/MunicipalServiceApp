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
    public partial class Announcements : Form
    {
        // Sorted Dictionary to store events based on date
        private SortedDictionary<DateTime, List<AnnouncementsClass>> announcementDictionary = new SortedDictionary<DateTime, List<AnnouncementsClass>>();
        private string currentFilter = "All"; // To track whether "All", "Events", or "Announcements" is selected
        private Button currentSelectedButton; // Track the currently selected button



        public Announcements()
        {
            InitializeComponent();
            LoadTestData();  // This method will load some sample data for testing
            PopulateCategoryDropdown();  // Populate category options
            DisplayFilteredEvents();  // Display all events by default
            SetButtonSelected(buttonAll); // Initially set the first button as selected
        }

        // Method to load test data (this can later be replaced by actual data retrieval)
        private void LoadTestData()
        {
            List<AnnouncementsClass> events = new List<AnnouncementsClass>
            {
                new AnnouncementsClass { Title = "Community Clean-Up", Description = "Join us to clean up the park.", Date = new DateTime(2024, 10, 16), Category = "Community", Option = "Event" },
                new AnnouncementsClass { Title = "Sports Day", Description = "Local sports day for kids.", Date = new DateTime(2024, 10, 20), Category = "Sport", Option = "Announcement" },
                new AnnouncementsClass { Title = "Music Festival", Description = "Annual music fest.", Date = new DateTime(2024, 11, 10), Category = "Entertainment", Option = "Event" },
                new AnnouncementsClass { Title = "Town Hall Meeting", Description = "Discuss local issues with the mayor.", Date = new DateTime(2024, 10, 18), Category = "Community", Option = "Announcement" },
                new AnnouncementsClass { Title = "Basketball Tournament", Description = "Inter-school basketball tournament.", Date = new DateTime(2024, 10, 22), Category = "Sport", Option = "Event" },
                new AnnouncementsClass { Title = "Food Festival", Description = "Taste the best local cuisines.", Date = new DateTime(2024, 10, 25), Category = "Community", Option = "Event" },
                new AnnouncementsClass { Title = "Job Fair", Description = "Opportunities for job seekers.", Date = new DateTime(2024, 11, 02), Category = "Other", Option = "Announcement" },
                new AnnouncementsClass { Title = "Art Exhibition", Description = "Showcase of local artists.", Date = new DateTime(2024, 11, 05), Category = "Community", Option = "Event" },
                new AnnouncementsClass { Title = "Charity Run", Description = "Participate in a charity run to support local causes.", Date = new DateTime(2024, 10, 25), Category = "Sport", Option = "Event" },
                new AnnouncementsClass { Title = "Halloween Celebration", Description = "Join us for a spooky Halloween party!", Date = new DateTime(2024, 10, 31), Category = "Community", Option = "Event" }
            };

            foreach (var ev in events)
            {
                // Insert event into announcement dictionary
                if (!announcementDictionary.ContainsKey(ev.Date))
                {
                    announcementDictionary[ev.Date] = new List<AnnouncementsClass>();
                }
                announcementDictionary[ev.Date].Add(ev);

            }
        }

        private void PopulateCategoryDropdown()
        {
            // Predefined categories: "All", "Sport", "Community", "Other"
            comboBoxCategory.Items.Add("All");
            //comboBoxCategory.Items.AddRange(categoriesSet.ToArray()); // Add unique categories from the set
            comboBoxCategory.Items.Add("Sport");
            comboBoxCategory.Items.Add("Community");
            comboBoxCategory.Items.Add("Entertainment");
            comboBoxCategory.Items.Add("Other");

            comboBoxCategory.SelectedIndex = 0; // Default to "All"

            // Attach event handler for when category selection changes
            comboBoxCategory.SelectedIndexChanged += ComboBoxCategory_SelectedIndexChanged;
        }

        // Event handler for when the category is changed
        private void ComboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayFilteredEvents();  // Trigger search when category is changed
        }

        // Event handler for when the date is changed
        private void DateTimePickerSearch_ValueChanged(object sender, EventArgs e)
        {
            DisplayFilteredEvents();  // Trigger search when date is changed
        }

        // Search functionality based on selected filter, category, and date
        private void DisplayFilteredEvents()
        {
            string selectedCategory = comboBoxCategory.SelectedItem?.ToString();
            DateTime selectedDate = dateFilter.Value;

            var filteredEvents = announcementDictionary.Where(kv => kv.Key >= selectedDate)
                                                .SelectMany(kv => kv.Value)
                                                .Where(ev => (selectedCategory == "All" || ev.Category == selectedCategory));

            // Apply the current filter ("All", "Events", "Announcements")
            if (currentFilter == "Events")
            {
                filteredEvents = filteredEvents.Where(ev => ev.Option == "Event");
            }
            else if (currentFilter == "Announcements")
            {
                filteredEvents = filteredEvents.Where(ev => ev.Option == "Announcement");
            }

            // Clear existing items before populating new ones
            listViewAnnouncements.Items.Clear();

            // Populate ListView
            foreach (var ev in filteredEvents)
            {
                ListViewItem item = new ListViewItem(ev.Title);
                item.SubItems.Add(ev.Date.ToShortDateString());  // Add date
                item.SubItems.Add(ev.Description);  // Add description

                listViewAnnouncements.Items.Add(item);  // Add item to ListView
            }
        }

        // Separate method for search functionality (searches title and description)
        private void PerformSearch(string searchText)
        {
            var searchResults = announcementDictionary.SelectMany(kv => kv.Value)
                                              .Where(ev => ev.Title.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                           ev.Description.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                                              .ToList();

            // Clear existing items before adding search results
            listViewAnnouncements.Items.Clear();

            // Populate ListView with search results
            foreach (var ev in searchResults)
            {
                ListViewItem item = new ListViewItem(ev.Title);
                item.SubItems.Add(ev.Date.ToShortDateString());
                item.SubItems.Add(ev.Description);

                listViewAnnouncements.Items.Add(item);
            }
        }

        private void SetButtonSelected(Button selectedButton)
        {
            // Reset the color of the previous selected button (if any)
            if (currentSelectedButton != null)
            {
                currentSelectedButton.ForeColor = Color.Black;  // Default color
            }

            // Set the color of the new selected button
            selectedButton.ForeColor = Color.Green;  // Highlight selected button

            // Update the current selected button
            currentSelectedButton = selectedButton;
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            PerformSearch(searchText);  // Call the search method
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            SetButtonSelected(buttonAll);  // Highlight the "All" button

            currentFilter = "All";
            DisplayFilteredEvents();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            SetButtonSelected(btnEvents);  // Highlight the "All" button

            currentFilter = "Events";
            DisplayFilteredEvents();
        }

        private void btnAnnouncements_Click(object sender, EventArgs e)
        {
            SetButtonSelected(btnAnnouncements);  // Highlight the "All" button

            currentFilter = "Announcements";
            DisplayFilteredEvents();
        }

    }
}
