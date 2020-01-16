namespace Models
{
    using Helper;
    public class SilverClient : RegularCustomer
    {
        public SilverClient(int persons, decimal pricePerPerson) : base(persons, pricePerPerson) { }

        public override decimal getTotalPrice() 
        {
            return base.getTotalPrice();
        }
        
        public override decimal getDiscountByCondition(DiscountModel discountCupon, int customersQuantity, decimal totalAmount) 
        {
            if (Constants.MAXAMOUNT > totalAmount && totalAmount >= Constants.MIDMOUNT) 
            {
                return totalAmount - (totalAmount * (int)Percents.Ten / (int)Percents.OneHundrend);
            }

            return base.getDiscountByCondition(discountCupon, customersQuantity, totalAmount);
        }
    }
}