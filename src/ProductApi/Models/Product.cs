namespace WebApplication.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public long NetPrice { get; set; }
        public long GrossPrice { get; set; }
    }
}