namespace Models
{
    public class PlatinumClient : GoldClient
    {
        public PlatinumClient(int persons, decimal pricePerPerson) : base(persons, pricePerPerson) { }

        public override decimal getTotalPrice() 
        {
            return base.getTotalPrice();
        }

        public override string getDiscountByCondition(DiscountModel discountCupon, int customersQuantity, decimal totalAmount) 
        {
             if (2500 <= totalAmount)
             {
                return "platinum";
             }

            return base.getDiscountByCondition(discountCupon, customersQuantity, totalAmount);
        }
    }
}