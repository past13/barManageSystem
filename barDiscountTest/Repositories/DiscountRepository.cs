using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    using Helper;
    using Models;
    public class DiscountRepository : IDiscountRepository
    {
        private List<DiscountModel> couponeDiscountList = new List<DiscountModel>();

        public DiscountRepository()
        {
            DiscountModel discount1 = new DiscountModel
            {
                Id = 1,
                Name = "DIS10",
                DiscountPercent = 10
            };

            couponeDiscountList.Add(discount1);
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

        public DiscountModel GetDiscountByCouponeCode(string couponeCode)
        {      
            var result = new DiscountModel();   

            var discountObject = couponeDiscountList.FirstOrDefault( x => x.Name.Equals(couponeCode, StringComparison.OrdinalIgnoreCase));

            if (discountObject != null) 
            {
                result = discountObject;
            } 
            else 
            {
                result.Name = Constants.DEFAULTDISCOUNT;
            }

            return result;
        }

        public bool InsertCouponeDiscoutToList(string couponeCode, int percentage)
        {
            // couponeDiscountList.TryAdd(couponeCode, percentage);
            return Constants.INSERTED;
        }
    }
}
       