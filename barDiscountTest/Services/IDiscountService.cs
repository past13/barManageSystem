namespace Service
{
    public interface IDiscountService
    {
        decimal GetBill(int persons, decimal pricePerPerson, string couponeCod);
        string InsertCouponeDiscoutToList(string couponeCode, int percentage);
        
    } 
}