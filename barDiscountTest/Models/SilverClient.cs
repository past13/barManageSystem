namespace Models
{
    public class SilverClient : Customer
    {
        public SilverClient(int persons, decimal pricePerPerson) : base(persons, pricePerPerson) { }

        public override decimal getTotalPrice() 
        {
            return base.getTotalPrice();
        }
        
        public override decimal getDiscountByCondition(DiscountModel discountCupon, int customersQuantity, decimal totalAmount) 
        {
            if (2500 > totalAmount && totalAmount >= 2000) 
            {
                return totalAmount - (totalAmount * (int)Percents.Ten / (int)Percents.OneHundrend);
            }

            return base.getDiscountByCondition(discountCupon, customersQuantity, totalAmount);
        }
    }
}