using System.Linq;

namespace Service
{
    using Helper;
    using Models;
    using Repository;

    public class DiscountService : IDiscountService
    {
        private readonly IDiscountRepository _repository;
        public DiscountService(IDiscountRepository repository)
        {
            _repository = repository;
        }
        
        public bool InsertCouponeDiscoutToList(string couponeCode, int percentage) 
        {
            return _repository.InsertCouponeDiscoutToList(couponeCode, percentage);
        }

        public DiscountModel GetDiscountByTotalAmount(decimal totalSum)
        {
            var discountList = _repository.GetDiscountList();

            decimal smallestDiff = int.MaxValue;
            int index = Constants.STARTINDEX;
            foreach(var disc in discountList) 
            {
                var temp =  totalSum - disc.PriceRange;
                if (smallestDiff > temp)
                {
                    smallestDiff = disc.PriceRange - totalSum;
                    index = disc.Id - Constants.PREVIOUSDISCOUNT;
                }
            }

            var result = discountList.ElementAt(index);

            return result;
        }

        public decimal GetBill(int persons, decimal pricePerPerson, string couponeCode)
        {
            var client = new Client(persons, pricePerPerson);

            var totalSum = client.getTotalPrice();

            var discountByCoupon = _repository.GetDiscountByCouponeCode(couponeCode);
            var discountByTotalSum = GetDiscountByTotalAmount(totalSum);

            return client.getDiscount(totalSum, discountByCoupon, discountByTotalSum.DiscountPercent);
        }
    } 
}