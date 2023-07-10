using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product Title is required.")]
        public string? ProductName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Product Price is required.")]
        public decimal ProductPrice { get; set; }
    }
}