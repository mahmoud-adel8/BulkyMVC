using System.ComponentModel.DataAnnotations;

namespace Bulky.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [Range(0, 1000)]
        [Display(Name = "List Price")]
        public double ListPrice { get; set; }
        [Required]
        [Range(0, 1000)]
        [Display(Name = "Price for 1-50")]
        public double price { get; set; }
        [Required]
        [Range(0, 1000)]
        [Display(Name = "Price for 50+")]
        public double price50 { get; set; }
        [Required]
        [Range(0, 1000)]
        [Display(Name = "Price for 100+")]
        public double price100 { get; set; }
    }
}
