using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TelerikUI.Models
{
    public class SystemSerial
    {
        [Key]
        public int SystemSerialId { get; set; }

        public string OrderId { get; set; }
        public virtual Order Order { get; set; }

    }
}
