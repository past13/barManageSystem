namespace Models
{
    using Helper;
    public class GoldClient : SilverClient
    {
        public GoldClient(int persons, decimal pricePerPerson) : base(persons, pricePerPerson) { }

        public override decimal getTotalPrice() 
        {
            return base.getTotalPrice();
        }

        public override decimal getDiscountByCondition(DiscountModel discountCupon, int customersQuantity, decimal totalAmount) 
        {
            if (customersQuantity == (int)ClientNumber.Four && discountCupon.Name == Constants.STARCARD) 
            {
                return totalAmount - (totalAmount * (int)Percents.Thirty / (int)Percents.OneHundrend);
            }

            if (customersQuantity == (int)ClientNumber.Two && discountCupon.Name == Constants.STARCARD) 
            {
                return totalAmount - (totalAmount * (int)Percents.TwentyFive / (int)Percents.OneHundrend);
            }

            return base.getDiscountByCondition(discountCupon, customersQuantity, totalAmount);
        }
    }
}