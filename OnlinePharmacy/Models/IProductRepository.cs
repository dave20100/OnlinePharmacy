using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePharmacy.Models
{
    public class IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
