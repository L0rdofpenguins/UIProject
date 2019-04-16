using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelerikUI.Models;

namespace TelerikUI.Interfaces
{
    interface ISystemSerial
    {
        IEnumerable<SystemSerial> GetAll();
        SystemSerial GetById(int id);
        string GetOrderId(int id);
        Order GetOrder(int id);

        IEnumerable<Material> GetMaterials(int id);
    }
}
