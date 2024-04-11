﻿

using System.Linq;
using Microsoft.EntityFrameworkCore;
using newINTEX.Models;
using newINTEX.Data;


namespace newINTEX.Models
{
    public class EFOrderRepository : IOrderRepository
    {
        private ApplicationDbContext _context;

        public EFOrderRepository(ApplicationDbContext ctx)
        {
            _context = ctx;
        }

        public IQueryable<Order> Orders => _context.Orders.Include(o => o.LineItems).ThenInclude(li => li.Product);

        public void SaveOrder(Order order)
        {
            if (order.TransactionID == 0)
            {
                foreach (var lineItem in order.LineItems)
                {
                    _context.Entry(lineItem).State = EntityState.Added; // Explicitly set the state of new line items
                }
                _context.Orders.Add(order);
            }
            else
            {
                _context.Entry(order).State = EntityState.Modified;
            }

            _context.SaveChanges();
        }
    }
}

