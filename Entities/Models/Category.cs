namespace Entities.Models
{
    public class Category
    {
        public int CategoryId { get; init; }

        public String? CategoryName { get; set; } = String.Empty;

        public ICollection<Product> Products { get; set; } // Collection navigation property
    }
}
