namespace ShopeeFake.Models
{
    public class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public long CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public virtual ICollection<Product> Products { get; set; } = null!;
    }
}