using System.Collections.Generic;

namespace Repository
{
    using Models;
    public class DiscountRepository : IDiscountRepository
    {
        private Dictionary<string, int> couponeDiscountList = new Dictionary<string, int>();

        public DiscountRepository()
        {
            couponeDiscountList.Add("NONE", 0);
            couponeDiscountList.Add("DIS10", 10);
            couponeDiscountList.Add("STARCARD", 30);
        }

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
                discount1,
                discount2
            });

            return discountList;
        }

        public int GetDiscountByCouponeCode(string couponeCode)
        {
            if (string.IsNullOrWhiteSpace(couponeCode)) 
            {
                couponeCode = "NONE";
            }

            return couponeDiscountList.ContainsKey(couponeCode) ? couponeDiscountList[couponeCode] : 0;
        }

        public bool InsertCouponeDiscoutToList(string couponeCode, int percentage)
        {
            couponeDiscountList.Add(couponeCode, percentage);
            return true;
        }
    }
}
       