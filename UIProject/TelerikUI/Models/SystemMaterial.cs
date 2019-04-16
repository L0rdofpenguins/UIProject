using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TelerikUI.Models
{
    public class SystemMaterial
    {
        [Key]
        public Guid SystemMaterialId { get; set; }

        public int SystemSerialId { get; set; }
        public SystemSerial System { get; set; }

        public string MaterialName { get; set; }
        public Material Material { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string SN { get; set; }

 
    }
}
