using System.Linq;

namespace OnlinePharmacy.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
