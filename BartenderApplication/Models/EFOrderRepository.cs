using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BartenderApplication.Contexts;

namespace BartenderApplication.Models
{
    public class EFOrderRepository : IOrderRepository
    {
        private MenuContext context;
        public EFOrderRepository(MenuContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<Order> Orders => context.Order;
        public void SaveOrder(Order order)
        {

            if (order.OrderId == 0)
            {
                context.Order.Add(order);
            }
            context.SaveChanges();
        }
    }
}
