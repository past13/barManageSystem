using System.Collections.Generic;

namespace Repository
{
    using Models;
    public class DiscountRepository : IDiscountRepository
    {
        public IEnumerable<DiscountModel> GetDiscountList()
        {
            List<DiscountModel> discountList = new List<DiscountModel>();
            
            var discount1 = new DiscountModel
            {
                Id = 1,
                PriceRange = 3000,
                DiscountPercent = 25
            };

            var discount2 = new DiscountModel
            {
                Id = 2,
                PriceRange = 2500,
                DiscountPercent = 20
            };
           
            discountList.AddRange(new List<DiscountModel>
            {
                discount1
            });

            return discountList;
        }

        public int GetDiscountByCouponeCode(string couponeCode)
        {
            if (string.IsNullOrWhiteSpace(couponeCode)) 
            {
                couponeCode = "NONE";
            }

            Dictionary<string, int> discountList = new Dictionary<string, int>();
            discountList.Add("NONE", 0);
            discountList.Add("DIS10", 10);
            discountList.Add("STARCARD", 30);

            return discountList.ContainsKey(couponeCode) ? discountList[couponeCode] : 0;
        }
    }
}
       