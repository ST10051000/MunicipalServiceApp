using MunicipalServiceApp.Data_Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MunicipalServiceApp
{
    /// <summary>
    /// This class manages service requests using multiple 
    /// data structures for various functionalities.
    /// </summary>
    public class ServiceRequestManager
    {
        // List to store all service requests.
        private List<ServiceRequestClass> requests = new List<ServiceRequestClass>();

        // Binary Search Tree to manage requests sorted by their ID.
        private BinarySearchTree bst = new BinarySearchTree();

        // MinHeap to manage requests based on their status priority.
        private MinHeap heap = new MinHeap();

        // Graph to track dependencies between service requests.
        private Graph graph = new Graph();

        //----------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Method adds a new service request to all underlying data structures.
        /// </summary>
        /// <param name="request"></param>
        public void AddRequest(ServiceRequestClass request)
        {
            bst.Insert(request); // Insert the request into the binary search tree (sorted by ID).
            heap.Insert(request); // Insert the request into the min-heap (sorted by status priority).
            graph.AddRequest(request); // Add the request as a node in the graph (for dependencies).
            requests.Add(request); // Add the request to the main list for raw access.
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Retrieves all service requests sorted by their ID 
        /// using an in-order traversal of the BST.
        /// </summary>
        /// <returns></returns>
        public List<ServiceRequestClass> GetSortedById()
        {
            return bst.InOrderTraversal();
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Retrieves all service requests as a raw list (unsorted).
        /// </summary>
        /// <returns></returns>
        public List<ServiceRequestClass> GetAllRequests()
        {
            return requests;
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// // Searches for a service request by ID using the binary search tree.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ServiceRequestClass SearchById(int id)
        {
            return bst.Search(id);
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Retrieves all service requests sorted by their status priority using the min-heap.
        /// </summary>
        /// <returns></returns>
        public List<ServiceRequestClass> GetSortedByStatus()
        {
            List<ServiceRequestClass> sortedList = new List<ServiceRequestClass>();

            // Create a copy of the heap to avoid modifying the original heap
            MinHeap heapCopy = new MinHeap();

            // Get all requests from the heap
            foreach (var request in heap.GetAllRequests())  
            {
                // Insert all items into the copied heap
                heapCopy.Insert(request);  
            }

            // Extract from the copied heap to get sorted data
            ServiceRequestClass min;
            while ((min = heapCopy.ExtractMin()) != null)
            {
                sortedList.Add(min);
            }

            return sortedList;
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Retrieves the dependencies of a given service request using the graph.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public List<ServiceRequestClass> GetDependencies(ServiceRequestClass request)
        {
            // Returns a list of requests that depend on the given request.
            return graph.GetDependencies(request);
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        public void UpdateRequest(ServiceRequestClass updatedRequest)
        {
            var existingRequest = requests.FirstOrDefault(r => r.ID == updatedRequest.ID);
            if (existingRequest != null)
            {
                existingRequest.Status = updatedRequest.Status;
            }
        }

    }
}
//-------------------------------------------------------------THE END----------------------------------------------------------------------
