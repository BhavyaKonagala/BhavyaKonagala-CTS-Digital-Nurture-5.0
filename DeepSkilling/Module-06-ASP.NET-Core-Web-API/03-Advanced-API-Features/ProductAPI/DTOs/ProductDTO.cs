using System.ComponentModel.DataAnnotations;

namespace ProductAPI.DTOs
{
    public class ProductDTO
    {
        [Required]
        [StringLength(100)]
        public required string Name { get; set; }

        [Range(1, 100000)]
        public decimal Price { get; set; }

        [Required]
        public required string Category { get; set; }

        [Range(0, 1000)]
        public int Stock { get; set; }
    }
}