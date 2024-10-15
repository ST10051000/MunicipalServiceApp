using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServiceApp
{
    public class AnnouncementsClass
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public AnnouncementsClass()
        {

        }

        /// <summary>
        /// Declaring and setting variables
        /// </summary>
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Option { get; set; }
        public string Category { get; set; }
    }
}