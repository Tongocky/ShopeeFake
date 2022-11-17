namespace ShopeeFake.Dto
{
    public class ProductDto
    {
        public long ProductId { get; set; }
        public long CategoryId { get; set; }

        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string ProductName { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime EnteredDate { get; set; }
        public string? Image { get; set; }
    }
}