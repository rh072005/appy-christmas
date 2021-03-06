namespace WebApplication.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public double NetPrice { get; set; }
        public double GrossPrice { get; set; }
        public string ImageUrl { get; set; }
    }
}