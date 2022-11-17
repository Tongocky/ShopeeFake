namespace ShopeeFake.Models
{
    public class Cart
    {
        public long CartId { get; set; }
        public decimal Amount { get; set; }
        public long UserId { get; set; }
        public string Address { get; set; } = null!;
        public int Phone { get; set; }
        public virtual User User { get; set; } = null!;
    }
}