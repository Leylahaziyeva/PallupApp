using PallupApp.DataContext.Entities;

namespace PallupApp.Models
{
    public class HomeViewModel
    {
        public List<Product> Products { get; set; } = new();
        public List<Category> Categories { get; set; } = new();
    }
}
