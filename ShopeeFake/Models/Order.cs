namespace ShopeeFake.Models
{
    public class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public long OrderId { get; set; }
        public string Address { get; set; } = null!;
        public decimal Amount { get; set; }
        public DateTime OrderDate { get; set; }
        public int Phone { get; set; }
        public bool Status { get; set; }
        public long UserId { get; set; }
        public virtual User User { get; set; } = null!;
        public virtual ICollection<OrderDetail> OrderDetails { get; set; } = null!;
    }
}