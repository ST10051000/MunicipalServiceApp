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
        // Using Sorted Dictionary to store events based on date
        // Using Priority Queue for managing events based on their date
        private SortedDictionary<DateTime, Queue<AnnouncementsClass>> priorityQueue = new SortedDictionary<DateTime, Queue<AnnouncementsClass>>();

        // Using a list to track user search patterns
        private List<string> searchHistory = new List<string>();

        // Using a hashset for unique categories
        private HashSet<string> uniqueCategories = new HashSet<string>();

        // To track whether "All", "Events", or "Announcements" is selected
        private string currentFilter = "All";

        // To track the currently selected button
        private Button currentSelectedButton;
        
        //----------------------------------------------------------------------------------------------------------------------------------

        public Announcements()
        {
            InitializeComponent();
            LoadTestData();  // Method that loads some sample data for testing
            PopulateCategoryDropdown();  // Method that populates category options
            DisplayFilteredEvents();  // Method that displays all events/announcements by default
            SetButtonSelected(buttonAll); // Initially set buttonAll as selected

            dateFilter.ValueChanged += (sender, e) => DisplayEventsForSelectedDate(); // Calling DisplayEventsForSelectedDate() method
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        // Method that loads test data
        private void LoadTestData()
        {
            // Saving all the data to a list
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

            // Using a priority qeue to ensurethere are no duplicate categories
            foreach (var ev in events)
            {             
                // Adding event to the priority queue, based on the event's date
                if (!priorityQueue.ContainsKey(ev.Date))
                {
                    priorityQueue[ev.Date] = new Queue<AnnouncementsClass>();
                }

                // Enqueue the event for the given date
                priorityQueue[ev.Date].Enqueue(ev);

                // Add category and date to the sets to ensure uniqueness
                uniqueCategories.Add(ev.Category);  
            }
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        // Using Sets to add unique categories to the dropdown box
        private void PopulateCategoryDropdown()
        {
            comboBoxCategory.Items.Add("All");

            // Add unique categories from the set
            foreach (var category in uniqueCategories)
            {
                comboBoxCategory.Items.Add(category);
            }

            // Default to "All"
            comboBoxCategory.SelectedIndex = 0; 

            // Attaching event handler for when category selection changes
            comboBoxCategory.SelectedIndexChanged += ComboBoxCategory_SelectedIndexChanged;
        }

        //----------------------------------------------------------------------------------------------------------------------------------

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

        //----------------------------------------------------------------------------------------------------------------------------------

        // Search functionality based on selected filter and category
        private void DisplayFilteredEvents()
        {
            string selectedCategory = comboBoxCategory.SelectedItem?.ToString();

            // Retrieving all events from the priority queue 
            var filteredEvents = priorityQueue.SelectMany(kv => kv.Value)
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
                item.SubItems.Add(ev.Date.ToShortDateString());  
                item.SubItems.Add(ev.Description);

                // Add item to ListView
                listViewAnnouncements.Items.Add(item);  
            }
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        // Method that displays events for the selected date
        private void DisplayEventsForSelectedDate()
        {
            // Getting the selected date from DateTimePicker
            DateTime selectedDate = dateFilter.Value;  

            // Retrieve events that match the selected date
            var eventsForSelectedDate = priorityQueue
                .Where(kv => kv.Key.Date == selectedDate.Date)  
                .SelectMany(kv => kv.Value);

            // Apply the current filter ("All", "Events", "Announcements")
            if (currentFilter == "Events")
            {
                eventsForSelectedDate = eventsForSelectedDate.Where(ev => ev.Option == "Event");
            }
            else if (currentFilter == "Announcements")
            {
                eventsForSelectedDate = eventsForSelectedDate.Where(ev => ev.Option == "Announcement");
            }

            // Clear existing items before populating new ones
            listViewAnnouncements.Items.Clear();

            // Populate ListView with events for the selected date
            foreach (var ev in eventsForSelectedDate)
            {
                ListViewItem item = new ListViewItem(ev.Title);
                item.SubItems.Add(ev.Date.ToShortDateString());  
                item.SubItems.Add(ev.Description);

                // Add item to ListView
                listViewAnnouncements.Items.Add(item);  
            }

            // Message when no events are found for selected date
            if (!eventsForSelectedDate.Any())
            {
                MessageBox.Show("No events found for this date.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        // Method for search functionality (searches title and description)
        private void SearchEvent(string searchText)
        {
            // Adding to search history
            if (!string.IsNullOrWhiteSpace(searchText) && !searchHistory.Contains(searchText))
            {
                searchHistory.Add(searchText);
            }

            var searchResults = priorityQueue.SelectMany(kv => kv.Value)
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

            // Message when search is not found
            if (!searchResults.Any())
            {
                MessageBox.Show("Search not found.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Get recommendations based on the search text
            GetRecommendations(searchText);
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        // Method to display recommendations according to recent searches
        private void GetRecommendations(string searchText)
        {
            var recommendations = priorityQueue.SelectMany(kv => kv.Value)
                .Where(ev => ev.Title.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                             ev.Description.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            // Populate ListView with recommendations
            foreach (var ev in recommendations)
            {
                ListViewItem item = new ListViewItem(ev.Title);
                item.SubItems.Add(ev.Date.ToShortDateString());
                item.SubItems.Add(ev.Description);

                listViewRecommendations.Items.Add(item);
            }
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        // Method to change the text colour when the button is selected
        private void SetButtonSelected(Button selectedButton)
        {
            // Reset the color of the previous selected button (if any)
            if (currentSelectedButton != null)
            {
                currentSelectedButton.ForeColor = Color.White;  
            }

            // Set the color of the new selected button
            selectedButton.ForeColor = Color.DarkOrange;  

            // Update the current selected button
            currentSelectedButton = selectedButton;
        }

        //----------------------------------------------------------------------------------------------------------------------------------
        
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            SearchEvent(searchText);  // Calling the search method
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            SetButtonSelected(buttonAll);  // Highlighting the "All" button

            currentFilter = "All";
            DisplayFilteredEvents(); // Calling the display method
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            SetButtonSelected(btnEvents);  // Highlighting the "Events" button

            currentFilter = "Events";
            DisplayFilteredEvents(); // Calling the display method
        }

        private void btnAnnouncements_Click(object sender, EventArgs e)
        {
            SetButtonSelected(btnAnnouncements);  // Highlighting the "Announcements" button

            currentFilter = "Announcements";
            DisplayFilteredEvents(); // Calling the display method
        }

        //----------------------------------------------------------------------------------------------------------------------------------

    }
}

//-------------------------------------------------------------THE END----------------------------------------------------------------------
// (OpenAI, 2024)
// https://chatgpt.com/share/670ec6ab-9528-8012-9e1f-76c0a6ea0416
// Layout of what it should look like