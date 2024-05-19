using System.ComponentModel.DataAnnotations;

namespace ProductListingApp.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Product name is required")]
        [StringLength(100, ErrorMessage = "Product name cannot exceed 100 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Product description is required")]
        [StringLength(500, ErrorMessage = "Product description cannot exceed 500 characters")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Product price is required")]
        [Range(0, double.MaxValue, ErrorMessage = "Product price must be a positive number")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Product quantity is required")]
        [Range(0, int.MaxValue, ErrorMessage = "Product quantity must be a non-negative number")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Product category is required")]
        [StringLength(50, ErrorMessage = "Product category cannot exceed 50 characters")]
        public string Category { get; set; }
    }
}
