namespace ShopeeFake.Models
{
    public class Rate
    {
        public long RateId { get; set; }
        public string Comment { get; set; } = null!;
        public DateTime RateDate { get; set; }
        public int RatingStar { get; set; }
        public long OrderDetailId { get; set; }
        public long ProductId { get; set; }
        public long UserId { get; set; }
        public virtual User User { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}