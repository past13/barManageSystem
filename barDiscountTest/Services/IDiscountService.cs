namespace Service
{
    public interface IDiscountService
    {
        decimal GetBill(int persons, decimal pricePerPerson, string couponeCod);
        bool InsertCouponeDiscoutToList(string couponeCode, int percentage);
        
    } 
}