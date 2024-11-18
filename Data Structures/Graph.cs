using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServiceApp.Data_Structures
{
    /// <summary>
    /// This class represents a directed graph structure
    /// to manage service requests and their dependencies.
    /// </summary>
    public class Graph
    {
        // This is a list that maps each service request to its list of dependent requests.
        private Dictionary<ServiceRequestClass, List<ServiceRequestClass>> adjList = new Dictionary<ServiceRequestClass, List<ServiceRequestClass>>();

        //----------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// This method sdds a service request to the graph as a node.
        /// </summary>
        /// <param name="request"></param>
        public void AddRequest(ServiceRequestClass request)
        {
            // Ensuring the request is added to the graph if it doesn't already exist.
            if (!adjList.ContainsKey(request))
                adjList[request] = new List<ServiceRequestClass>();
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// This method adds a directed dependency between two service requests.
        /// 'from' is the source request, and 'to' is the dependent request.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public void AddDependency(ServiceRequestClass from, ServiceRequestClass to)
        {
            // Only adding the dependency if the source request exists in the graph.
            if (adjList.ContainsKey(from))
                adjList[from].Add(to);
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// This method retrieves all dependencies for a given service request.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public List<ServiceRequestClass> GetDependencies(ServiceRequestClass request)
        {
            // Return the list of dependencies if the request exists in the graph.
            // Otherwise, return an empty list.
            return adjList.ContainsKey(request) ? adjList[request] : new List<ServiceRequestClass>();
        }
    }
}

//-------------------------------------------------------------THE END----------------------------------------------------------------------

