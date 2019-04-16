using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelerikUI.Models
{
    public class OrderDTO
    {
        public string OrderId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime? FinishDate { get; set; }

        public virtual ICollection<SystemSerial> SystemSerials { get; set; }
    }
}
