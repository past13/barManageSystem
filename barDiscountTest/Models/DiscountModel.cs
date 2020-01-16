namespace Models
{
    public class DiscountModel
    {
        public int Id { get; set; }
        public string Name {get; set; }
        public decimal PriceRange { get; set; }
        public int DiscountPercent { get; set; }
    }
}