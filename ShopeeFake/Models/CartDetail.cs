namespace ShopeeFake.Models
{
    public class CartDetail
    {
        public long CartDetailId { get; set; }
        public int Quantity { get; set; }
        public long ProductId { get; set; }
        public long CartId { get; set; }
        public decimal Price { get; set; }
        public virtual Product Product { get; set; } = null!;
    }
}