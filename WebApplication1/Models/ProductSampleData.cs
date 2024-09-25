using static System.Net.Mime.MediaTypeNames;

namespace WebApplication1.Models
{
    public class ProductSampleData
    {
        List<Product>products = new List<Product>();
        public ProductSampleData()
        {
            products.Add(new Product{ Id = 1, name = "Iphone", price = 10000, description = "phone1" , Image = "Iphone.jpg" });
            products.Add(new Product { Id = 2, name = "Samsung Galaxy", price = 8500, description = "phone2", Image = "samsung a30.jpg" });
            products.Add(new Product { Id = 3, name = "Google Pixel", price = 7200, description = "phone3", Image = "samsungphone.jpg" });
            products.Add(new Product { Id = 4, name = "OnePlus", price = 6500, description = "phone4", Image = "Iphone.jpg" });
            products.Add(new Product { Id = 5, name = "Sony Xperia", price = 7800, description = "phone5", Image = "samsung a30.jpg" });
            products.Add(new Product { Id = 6, name = "Huawei P50", price = 9000, description = "phone6", Image = "samsungphone.jpg" });
        }
        public List<Product> GetAll() => products;
        public Product  GetById(int id)
        {
            //return products[id]
            return products.FirstOrDefault(e => e.Id == id);
        }
        
       
    }
}
