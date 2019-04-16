using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelerikUI.Models;
using TelerikUI.Repository;

namespace TelerikUI.OrderServices
{
    public class OrderService : IOrder
    {
        private ApplicationDbContext _context;
        public OrderService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Order order)
        {
            _context.Add(order);
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            _context.Orders
                .Remove(GetById(id));
            _context.SaveChanges();
        }

        public IEnumerable<Order> GetAll()
        {
            return _context.Orders
                .Include(o => o.SystemSerials);
        }

        public Order GetById(string id)
        {
            return _context.Orders
                .Include(o=>o.SystemSerials)
                .SingleOrDefault(o=>o.OrderId==id);
        }

        public DateTime? GetFinishDate(string id)
        {
            return GetById(id).FinishDate;
        }
      
        public DateTime GetStartDate(string id)
        {
            return GetById(id).StartDate;
        }

        public ICollection<SystemSerial> GetSerials(string id)
        {
            return GetById(id).SystemSerials;
        }

        public void MakeFinished(string id)
        { 
            GetById(id).FinishDate=DateTime.Now;
            _context.SaveChanges();
        }

        public bool IsFulfilled(string id)
        {
            return GetById(id).FinishDate != null;
        }
    }
}
