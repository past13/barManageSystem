namespace Models
{
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

        public virtual decimal getDiscountByCondition(DiscountModel discountCupon, int customersQuantity, decimal totalAmount) 
        {
            return totalAmount;
        }
    }
}