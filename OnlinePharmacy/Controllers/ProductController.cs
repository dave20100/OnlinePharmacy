using Microsoft.AspNetCore.Mvc;
using OnlinePharmacy.Models;
using System.Linq;

namespace OnlinePharmacy.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public int PageSize = 1;
        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }

        public ViewResult List(int productPage = 1) => View(repository.Products.OrderBy(p => p.ProductID)
            .Skip((productPage - 1) * PageSize).Take(PageSize));
    }
}
