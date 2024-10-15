﻿using System;
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
                uniqueCategories.Add(ev.Category);  // Ensures no duplicate categories
            }
        }

        private void PopulateCategoryDropdown()
        {
            // Predefined categories: "All", "Sport", "Community", "Other"
            comboBoxCategory.Items.Add("All");

            // Add unique categories from the set
            foreach (var category in uniqueCategories)
            {
                comboBoxCategory.Items.Add(category);
            }

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

            // Retrieve all events from the priority queue that are on or after the selected date
            var filteredEvents = priorityQueue.Where(kv => kv.Key >= selectedDate)
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
            // Add to search history
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

            // Get recommendations based on the search text
            GetRecommendations(searchText);
        }

        // Method to display events for the selected date
        private void DisplayEventsForSelectedDate()
        {
            DateTime selectedDate = dateFilter.Value;  // Get the selected date from DateTimePicker

            // Retrieve events that match the exact selected date
            var eventsForSelectedDate = priorityQueue
                .Where(kv => kv.Key.Date == selectedDate.Date)  // Match events by exact date
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
                item.SubItems.Add(ev.Date.ToShortDateString());  // Add date
                item.SubItems.Add(ev.Description);  // Add description

                listViewAnnouncements.Items.Add(item);  // Add item to ListView
            }

            // If no events are found, you can show a message
            if (!eventsForSelectedDate.Any())
            {
                MessageBox.Show("No events found for the selected date.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void GetRecommendations(string searchText)
        {
            var recommendations = priorityQueue.SelectMany(kv => kv.Value)
                .Where(ev => ev.Title.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                             ev.Description.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            // Clear existing items before adding recommendations
            listViewRecommendations.Items.Clear();

            // Populate ListView with recommendations
            foreach (var ev in recommendations)
            {
                ListViewItem item = new ListViewItem(ev.Title);
                item.SubItems.Add(ev.Date.ToShortDateString());
                item.SubItems.Add(ev.Description);

                listViewRecommendations.Items.Add(item);
            }
        }


        private void SetButtonSelected(Button selectedButton)
        {
            // Reset the color of the previous selected button (if any)
            if (currentSelectedButton != null)
            {
                currentSelectedButton.ForeColor = Color.White;  // Default color
            }

            // Set the color of the new selected button
            selectedButton.ForeColor = Color.DarkOrange;  // Highlight selected button

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
