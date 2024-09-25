using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string name { get; set; }

        public double price { get; set; }

        public string description { get; set; }
        public  string Image  { get; set; }

    }
}
