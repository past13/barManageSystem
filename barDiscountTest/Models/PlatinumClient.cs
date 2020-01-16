namespace Models
{
    using Helper;
    public class PlatinumClient : GoldClient
    {
        public PlatinumClient(int persons, decimal pricePerPerson) : base(persons, pricePerPerson) { }

        public override decimal getTotalPrice() 
        {
            return base.getTotalPrice();
        }

        public override decimal getDiscountByCondition(DiscountModel discountCupon, int customersQuantity, decimal totalAmount) 
        {
             if (Constants.MAXAMOUNT <= totalAmount)
             {
                return totalAmount - (totalAmount * (int)Percents.TwentyFive / (int)Percents.OneHundrend);
             }

            return base.getDiscountByCondition(discountCupon, customersQuantity, totalAmount);
        }
    }
}