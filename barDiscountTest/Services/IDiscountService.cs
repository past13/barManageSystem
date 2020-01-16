namespace Service
{
    public interface IDiscountService
    {
        decimal GetBill(int persons, decimal pricePerPerson, string couponeCod);
    } 
}