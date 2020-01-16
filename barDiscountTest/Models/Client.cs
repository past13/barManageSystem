namespace Models
{
    public class Client : Customer
    {
        private int PeopleQuantity {get; set;}
        private decimal PricePerPerson {get; set;}


        public Client(int persons, decimal pricePerPerson) 
        {
            PeopleQuantity = persons;
            PricePerPerson = pricePerPerson;
        }

        public decimal getTotalPrice() 
        {
            return PeopleQuantity * PricePerPerson;
        }

        public override decimal getDiscount(decimal totalPrice, int discountPercentage, int discountByTotalSum) 
        {
            return base.getDiscount(totalPrice, discountPercentage, discountByTotalSum);
        }
    }
}