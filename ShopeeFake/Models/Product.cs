namespace ShopeeFake.Models
{
    public class Product
    {
        public Product()
        {
            Rates = new HashSet<Rate>();
            CartDetails = new HashSet<CartDetail>();
            OrderDetails = new HashSet<OrderDetail>();
        }

        public long ProductId { get; set; }
        public string? Description { get; set; }
        public int? Discount { get; set; }
        public DateTime EnteredDate { get; set; }
        public string? Image { get; set; }
        public string ProductName { get; set; } = null!;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public bool Status { get; set; }
        public long CategoryId { get; set; }
        public int? Sold { get; set; }
        public virtual Category Category { get; set; } = null!;
        public virtual ICollection<Rate> Rates { get; set; }
        public virtual ICollection<CartDetail> CartDetails { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}