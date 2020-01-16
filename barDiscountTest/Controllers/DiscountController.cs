using Microsoft.AspNetCore.Mvc;

namespace barDiscountTest.Controllers
{
    using Service;
    
    [Produces("application/json")]
    [Route("api/prices")]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _service;
        public DiscountController(IDiscountService service)
        {
            _service = service;
        }

        [HttpPost("discount")]
        public string InsertDiscount(string couponeCode, int percentage)
        {
            return _service.InsertCouponeDiscoutToList(couponeCode, percentage);
        }

        [HttpGet("bill")]
        public decimal GetBill(int persons, decimal pricePerPerson, string couponeCode)
        {
            if (persons < 0) 
            {
            }

            if (pricePerPerson < 0) 
            {
            }

            return _service.GetBill(persons, pricePerPerson, couponeCode);
        }
    }
}
