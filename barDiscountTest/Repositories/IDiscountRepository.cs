using System.Collections.Generic;

namespace Repository
{
    using Models;
    public interface IDiscountRepository
    {
        IEnumerable<DiscountModel> GetDiscountList();
        DiscountModel GetDiscountByCouponeCode(string couponeCode);
        bool InsertCouponeDiscoutToList(string couponeCode, int percentage);
    } 
}