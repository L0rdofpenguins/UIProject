using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelerikUI.Models;

namespace TelerikUI
{
    public interface IOrder
    {
        IEnumerable<Order> GetAll();
        Order GetById(string id);
        ICollection<SystemSerial> GetSerials(string id);
        DateTime GetStartDate(string id);
        DateTime? GetFinishDate(string id);
        bool IsFulfilled(string id);

        void Add(Order order);
        void Delete(string id);
        void MakeFinished(string id);

    }
}
