using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServiceApp
{
    public class ServiceRequestClass
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public ServiceRequestClass()
        {

        }

        /// <summary>
        /// Declaring and setting variables
        /// </summary>
        public int ID { get; set; }
        public string Category { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public string Status { get; set; }
        public DateTime DateRequested { get; set; }

        /// <summary>
        /// Method to determine the priority of a service request based on its status.
        /// </summary>
        /// <returns></returns>
        public int GetStatusPriority()
        {
            switch (Status)
            {
                case "Pending":
                    return 1;
                case "In Progress":
                    return 2;
                case "Completed":
                    return 3;
                default:
                    return int.MaxValue; 
            }
        }
    }
}
//-------------------------------------------------------------THE END----------------------------------------------------------------------
