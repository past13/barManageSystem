using System;
using System.Linq;
using System.Collections.Generic;

namespace Service
{
    using Models;
    public class DiscountService : IDiscountService
    {
        public static IEnumerable<DiscountModel> GetDiscountList()
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
        public static string InsertDiscoutToList() 
        {

            return "Inserted";
        }
        public static int GetDiscountByCouponeCode(string couponeCode)
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

        public static DiscountModel GetDiscountByTotalAmount(decimal totalSum)
        {
            var discountList = GetDiscountList();

            decimal smallestDiff = int.MaxValue;
            int index = 0;
            foreach(var disc in discountList) 
            {
                var temp =  totalSum - disc.PriceRange;
                if (smallestDiff > temp)
                {
                    smallestDiff = disc.PriceRange - totalSum;
                    index = disc.Id - 1;
                }
            }

            var result = discountList.ElementAt(index);

            return result;
        }

        public decimal GetBill(int persons, decimal pricePerPerson, string couponeCode)
        {
            var client = new Client(persons, pricePerPerson);

            var totalSum = client.getTotalPrice();

            var discountByTotalSum = GetDiscountByTotalAmount(totalSum);
            var discountByCoupon = GetDiscountByCouponeCode(couponeCode);

            return client.getDiscount(totalSum, discountByCoupon, discountByTotalSum.DiscountPercent);
        }
    } 
}