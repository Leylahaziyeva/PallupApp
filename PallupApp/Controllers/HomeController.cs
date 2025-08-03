using Microsoft.AspNetCore.Mvc;
using PallupApp.DataContext;

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
            return View();
        }  
    }
}