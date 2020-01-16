namespace Models
{
    using Helper;
    public abstract class RegularCustomer
    {
        public int PeopleQuantity { get; set; }
        public decimal PricePerPerson { get; set; }
        protected RegularCustomer(int persons, decimal pricePerPerson) 
        {
            PeopleQuantity = persons;
            PricePerPerson = pricePerPerson;
        }
        public virtual decimal getTotalPrice() 
        {
            return PeopleQuantity * PricePerPerson;
        }

        public virtual decimal getDiscountByCondition(DiscountModel discountCupon, int customersQuantity, decimal totalAmount) 
        {
            if (Constants.MIDMOUNT > totalAmount || discountCupon.Name == Constants.DEFAULTDISCOUNT )
            {
                return totalAmount;
            }

            return totalAmount;
        }
    }
}