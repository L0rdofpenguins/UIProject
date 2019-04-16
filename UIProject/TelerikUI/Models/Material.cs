using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TelerikUI.Models
{
    public class Material
    { 
        [Key]
        public string MaterialName { get; set; }
        public string Manufacturer { get; set; }



    }
}
