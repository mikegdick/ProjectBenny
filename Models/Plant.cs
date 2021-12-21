using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBenny.Models
{
    public class Plant
    {
        public int ID { get; set; }

        public string Name { get; set; }

        [Display(Name="Planted Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PlantedDate { get; set; }

        public string Species { get; set; }

        public string Location { get; set; }

    }
}
