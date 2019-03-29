using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePharmacy.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product { Name = "Ibuprom", Price = 12},
            new Product {Name = "Gripex", Price = 10}
        }.AsQueryable<Product>();
    }
}
