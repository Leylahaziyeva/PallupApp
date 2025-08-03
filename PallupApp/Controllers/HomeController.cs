using Microsoft.AspNetCore.Mvc;
using PallupApp.DataContext;
using PallupApp.Models;

namespace PallupApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var model = new HomeViewModel
            {
                Categories = _dbContext.Categories
                    .Where(c => c.ImageUrl != null)
                    .OrderBy(c => c.Name)
                    .ToList(),

                Products = _dbContext.Products
                    .OrderByDescending(p => p.Id) 
                    .Take(6)                   
                    .ToList()
            };

            return View(model);
        }
    }

}