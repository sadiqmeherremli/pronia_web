using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace pronia_web.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product>? Products { get; set;}
    }
}
