using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServiceApp
{
    public class ReportsClass
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public ReportsClass() 
        {
            
        }

        /// <summary>
        /// Declaring and setting variables
        /// </summary>
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; } 
    }
}
