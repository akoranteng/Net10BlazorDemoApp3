//@using Net10BlazorDemoApp3.Models
namespace Net10BlazorDemoApp3.Models
{
    public class Product
    //Define Product class
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? Category { get; set; }


    }
}
