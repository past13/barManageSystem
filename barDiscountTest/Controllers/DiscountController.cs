using Microsoft.AspNetCore.Mvc;

namespace barDiscountTest.Controllers
{
    using Helper;
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
        public IActionResult InsertDiscount(string couponeCode, int percentage)
        {
            if (percentage < 0) 
            {
                return BadRequest("Percentage can not be equal zero");
            }

            if (string.IsNullOrEmpty(couponeCode)) 
            {
                return BadRequest("Coupone code can not be empty");
            }

            couponeCode = StringValidation.ValidateStringInput(couponeCode);
            if (couponeCode.Length > Constants.MAXCOPOUNELENGTH) 
            {
                return BadRequest("Coupone code too long");
            }

            _service.InsertCouponeDiscoutToList(couponeCode, percentage);

            return Ok("succesfully inserted");
        }

        [HttpGet("bill")]
        public IActionResult GetBill(int persons, decimal pricePerPerson, string couponeCode)
        {
            if (persons < 0) 
            {
                return BadRequest("Can not be 0 visitors should be minimum 1");
            }

            if (pricePerPerson < 0) 
            {
                return BadRequest("Can not be 0 amount for bill");
            }

            var result = _service.GetBill(persons, pricePerPerson, couponeCode);
            return Ok(result);
        }
    }
}
