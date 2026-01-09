//@using Net10BlazorDemoApp3.Models
using System.ComponentModel.DataAnnotations;

namespace Net10BlazorDemoApp3.Models
{
    public class Product
    //Define Product class
    {

        public int Id { get; set; }
        [Required]
        [StringLength(100)]
       // public string Name { get; set; }

        public string? Name { get; set; }
        public string? Description { get; set; }
        [Range(0.01, 9999)]
        public decimal Price { get; set; }
        [Required]
        public string? Category { get; set; }


    }
}
