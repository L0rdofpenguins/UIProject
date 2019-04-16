using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelerikUI.Interfaces;
using TelerikUI.Models;
using TelerikUI.Repository;

namespace TelerikUI.OrderServices
{
    public class SystemSerialService : ISystemSerial
    {
        private ApplicationDbContext _context;
        public SystemSerialService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<SystemSerial> GetAll()
        {
            return _context.SystemSerials
                .Include(s=>s.OrderId);
        }

        public SystemSerial GetById(int id)
        {
            return GetAll()
                .SingleOrDefault(s => s.SystemSerialId == id);
        }

        public Order GetOrder(int id)
        {
            return GetById(id).Order;
        }

        public string GetOrderId(int id)
        {
            return GetById(id).OrderId;
        }

        public IEnumerable<Material> GetMaterials(int id)
        {
            throw new NotImplementedException();
        }
    }

}
