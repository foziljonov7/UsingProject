using Microsoft.AspNetCore.Mvc;
using UsingApiAppData.Services;

namespace UsingApiApp.Controllers
{
    [ApiController]
    [Route("CreditApi/Controller")]
    public class CreditController : ControllerBase
    {
        private readonly ICreditServices _creditServices;
        public CreditController(ICreditServices creditServices) 
        {
            _creditServices = creditServices;
        }
        [HttpGet]
        [Route("GetCredit")]
        public IActionResult GetCreditAll()
        {
            return Ok(_creditServices.GetCreditAll());
        }
        [HttpGet]
        [Route("GetCreditById/{Id}")]
        public IActionResult GetById(int Id)
        {
            return Ok(_creditServices.GetCreditById(Id));
        }
        [HttpGet]
        [Route("GetSearch/{FullName}")]
        public IActionResult GetSearch(string FullName)
        {
            return Ok(_creditServices.GetCreditSearch(FullName));
        }
    }
}
