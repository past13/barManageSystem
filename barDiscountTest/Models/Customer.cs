namespace Models
{
    public class Customer
    {
        public virtual decimal getDiscount(decimal totalPrice, int discountPercent, int discountByTotalSum)
        {
            if (discountPercent > discountByTotalSum) {
                return totalPrice - (totalPrice * discountPercent / 100);
            } 
            else 
            {
                return totalPrice - (totalPrice * discountByTotalSum / 100);
            }
        }
    }
}