namespace ShopeeFake.Models
{
    public class OrderDetail
    {
        public long OrderDetailId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public long OrderId { get; set; }
        public long ProductId { get; set; }
        public virtual Product Product { get; set; } = null!;
        public virtual Order Order { get; set; } = null!;
    }
}