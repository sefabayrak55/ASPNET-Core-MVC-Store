using Entities.Models;
using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public record ProductDto
    {
        public int ProductId { get; init; }

        [Required(ErrorMessage = "Product Title is required.")]
        public string? ProductName { get; init; } = string.Empty;

        [Required(ErrorMessage = "Product Price is required.")]
        public decimal ProductPrice { get; init; }

        public String? Summary { get; init; } = String.Empty;

        public String? ImageUrl { get; set; }

        public int? CategoryId { get; init; }

    }
}
