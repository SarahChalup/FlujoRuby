using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIproductor.Models
{
    public class Data
    {
        [Key]
        public string nameDevice { get; set; }
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime eventDate { get; set; }
        [Required]
        public string Event { get; set; }

    }
}
