using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Xml.Linq;

namespace MunicipalServiceApp.Data_Structures
{
    /// <summary>
    /// This class represents a Min-Heap data structure for managing 
    /// service requests based on priority.
    /// </summary>
    public class MinHeap
    {
        // Internal list to store the heap elements.
        private List<ServiceRequestClass> heap = new List<ServiceRequestClass>();

        //----------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// This method inserts a new service request into the heap.
        /// </summary>
        /// <param name="request"></param>
        public void Insert(ServiceRequestClass request)
        {
            heap.Add(request);
            HeapifyUp(heap.Count - 1);
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// This method removes and returns the service request with 
        /// the highest priority (minimum value).
        /// </summary>
        /// <returns></returns>
        public ServiceRequestClass ExtractMin()
        {
            // If the heap is empty, return null.
            if (heap.Count == 0) return null;

            var min = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);
            HeapifyDown(0);

            return min;
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// This method restores the min-heap property by moving 
        /// an element up the heap as necessary.
        /// </summary>
        /// <param name="index"></param>
        private void HeapifyUp(int index)
        {
            // Continue as long as the current element is not the root and has a smaller priority than its parent.
            while (index > 0 && heap[index].GetStatusPriority() < heap[(index - 1) / 2].GetStatusPriority())
            {
                Swap(index, (index - 1) / 2);
                index = (index - 1) / 2;
            }
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// This method restores the min-heap property by moving an element down the heap as necessary.
        /// </summary>
        /// <param name="index"></param>
        private void HeapifyDown(int index)
        {
            // Initializing the smallest index as the current index.
            int smallest = index;
            int left = 2 * index + 1;
            int right = 2 * index + 2;

            // Checking if the left child exists and has a smaller priority than the current smallest element.
            if (left < heap.Count && heap[left].GetStatusPriority() < heap[smallest].GetStatusPriority())
                smallest = left;

            // Check if the right child exists and has a smaller priority than the current smallest element.
            if (right < heap.Count && heap[right].GetStatusPriority() < heap[smallest].GetStatusPriority())
                smallest = right;

            // If the smallest element is not the current element, swap and recurse.
            if (smallest != index)
            {
                Swap(index, smallest);
                HeapifyDown(smallest);
            }
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// This method swaps two elements in the heap.
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        private void Swap(int i, int j)
        {
            var temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Returns a copy of all the requests in the heap.
        /// </summary>
        /// <returns></returns>
        public List<ServiceRequestClass> GetAllRequests()
        {
            // Returning a copy of the internal heap list
            return new List<ServiceRequestClass>(heap);  
        }
    }
}
//-------------------------------------------------------------THE END----------------------------------------------------------------------
