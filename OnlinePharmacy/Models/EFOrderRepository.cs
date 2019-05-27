using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePharmacy.Models
{
    public class EFOrderRepository : IOrderRepository
    {
        private ApplicationDbContext context;

        public EFOrderRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Order> Orders => context.Orders
            .Include(o => o.Lines)
            .ThenInclude(l => l.Product);

        public void SaveOrder(Order order)
        {
            foreach(var line in order.Lines)
            {
                var product = context.Products.FirstOrDefault(pro => pro.ProductID == line.Product.ProductID);
                if(product.AmountInStock - line.Quantity >= 0)
                {
                    product.AmountInStock -= line.Quantity;
                }
                else
                {
                    product.AmountInStock = 0;
                }
                context.SaveChanges();
            }
            //context.AttachRange(order.Lines.Select(l => l.Product));
            //if (order.OrderID == 0)
            //{
            //    context.Orders.Add(order);
            //}
            context.SaveChanges();
        }
    }
}
