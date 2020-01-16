using Helper;

namespace Models
{
    public class CustomerDiscount
    {
        public virtual decimal getDiscount(decimal totalPrice, int discountPercent, int discountByTotalSum)
        {
            if (discountPercent > discountByTotalSum) {
                return totalPrice - (totalPrice * discountPercent / Constants.ONEHUNDREDPERCENT);
            } 
            else 
            {
                return totalPrice - (totalPrice * discountByTotalSum / Constants.ONEHUNDREDPERCENT);
            }
        }
    }
}