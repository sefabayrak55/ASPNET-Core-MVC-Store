using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreApp.Models;
using System.Net.WebSockets;

namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly RepositoryContext _repositoryContext;

        public ProductController(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public IActionResult Index()
        {
            var products = _repositoryContext.Products.ToList();
            return View(products);
        }

        public IActionResult Get(int id)
        {
            var product = _repositoryContext.Products.First(p => p.ProductId.Equals(id));
            return View(product);
        }
    }
}
