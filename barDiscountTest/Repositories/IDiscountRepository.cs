using System.Collections.Generic;

namespace Repository
{
    using Models;
    public interface IDiscountRepository
    {
        IEnumerable<DiscountModel> GetDiscountList();
        int GetDiscountByCouponeCode(string couponeCode);
        bool InsertCouponeDiscoutToList(string couponeCode, int percentage);
    } 
}