using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServiceApp.Data_Structures
{
    /// <summary>
    /// This class represents a Binary Search Tree (BST) 
    /// for storing and retrieving service requests.
    /// </summary>
    public class BinarySearchTree
    {
        /// <summary>
        /// This is the root node of the BST.
        /// </summary>
        public BSTNode Root { get; private set; }

        //----------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// This methos inserts a new service request into the BST.
        /// </summary>
        /// <param name="request"></param>
        public void Insert(ServiceRequestClass request)
        {
            // Calling the recursive helper method to insert the request.
            Root = InsertRecursive(Root, request); 
        }

        /// <summary>
        /// This is a helper method to recursively insert a new service request 
        /// into the correct position in the BST.
        /// </summary>
        /// <param name="node"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        private BSTNode InsertRecursive(BSTNode node, ServiceRequestClass request)
        {
            // If the current node is null, create a new node with the service request data.
            if (node == null)
            {
                return new BSTNode { Data = request };
            }

            // Comparing the IDs to decide the direction of traversal.
            if (request.ID < node.Data.ID)
                node.Left = InsertRecursive(node.Left, request);
            else if (request.ID > node.Data.ID)
                node.Right = InsertRecursive(node.Right, request);

            return node;
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Searches for a service request in the BST by its ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ServiceRequestClass Search(int id)
        {
            return SearchRecursive(Root, id)?.Data;
        }

        /// <summary>
        /// This is a helper method to recursively search for 
        /// a service request in the BST by its ID.
        /// </summary>
        /// <param name="node"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        private BSTNode SearchRecursive(BSTNode node, int id)
        {
            if (node == null || node.Data.ID == id)
                return node;

            if (id < node.Data.ID)
                return SearchRecursive(node.Left, id);
            else
                return SearchRecursive(node.Right, id);
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// This method performs an in-order traversal of the BST 
        /// and returns a sorted list of service requests.
        /// </summary>
        /// <returns></returns>
        public List<ServiceRequestClass> InOrderTraversal()
        {
            var result = new List<ServiceRequestClass>();
            InOrderTraversalRecursive(Root, result);
            return result;
        }

        /// <summary>
        /// This is a helper method to recursively perform in-order 
        /// traversal of the BST.
        /// </summary>
        /// <param name="node"></param>
        /// <param name="result"></param>
        private void InOrderTraversalRecursive(BSTNode node, List<ServiceRequestClass> result)
        {
            if (node != null)
            {
                InOrderTraversalRecursive(node.Left, result);
                result.Add(node.Data); // Adding the current node's data to the result list.
                InOrderTraversalRecursive(node.Right, result);
            }
        }
    }

    //----------------------------------------------------------------------------------------------------------------------------------

    /// <summary>
    /// This represents a node in the Binary Search Tree.
    /// </summary>
    public class BSTNode
    {
        public ServiceRequestClass Data { get; set; }
        public BSTNode Left { get; set; }
        public BSTNode Right { get; set; }
    }
}
//-------------------------------------------------------------THE END----------------------------------------------------------------------
