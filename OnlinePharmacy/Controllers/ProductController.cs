using Microsoft.AspNetCore.Mvc;
using OnlinePharmacy.Models;

namespace OnlinePharmacy.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;

        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }

        public ViewResult List() => View(repository.Products);
    }
}
