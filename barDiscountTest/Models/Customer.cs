namespace Models
{
    using Helper;
    public abstract class Customer
    {
        public int PeopleQuantity { get; set; }
        public decimal PricePerPerson { get; set; }
        protected Customer(int persons, decimal pricePerPerson) 
        {
            PeopleQuantity = persons;
            PricePerPerson = pricePerPerson;
        }
        public virtual decimal getTotalPrice() 
        {
            return PeopleQuantity * PricePerPerson;
        }

        public virtual string getDiscountByCondition(DiscountModel discountCupon, int customersQuantity, decimal totalAmount) 
        {
            return "base";
        }

        // public virtual decimal getDiscountByCondition(decimal totalPrice, int discountPercent, int discountByTotalSum)
        // {
        //     if (discountPercent > discountByTotalSum) 
        //     {
        //         return totalPrice - (totalPrice * discountPercent / Constants.ONEHUNDREDPERCENT);
        //     } 
        //     else 
        //     {
        //         return totalPrice - (totalPrice * discountByTotalSum / Constants.ONEHUNDREDPERCENT);
        //     }
        // }
    }
}