using Microsoft.EntityFrameworkCore;

namespace PallupApp.DataContext.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; } = null!;           
        public string Description { get; set; } = null!; 

        [Precision(18, 2)]                                               
        public decimal CurrentPrice { get; set; }

        [Precision(18, 2)]
        public decimal? OldPrice { get; set; }         
        public float Rating { get; set; }             
        public string MainImageUrl { get; set; } = null!;          
        public string? SecondImageUrl { get; set; } 
        public int CategoryId { get; set; }          
        public Category? Category { get; set; }       
    }
}