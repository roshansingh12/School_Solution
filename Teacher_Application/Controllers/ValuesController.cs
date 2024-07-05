using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Teacher_Application.Controllers
{
    [Route("Teacher_api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("[Action]")]
        public ActionResult<int> CalculateSum(int? a, int? b)
        {
            return Ok(a+b);
        }
        [HttpGet("[Action]")]
        public IActionResult CalculateSub(int? a,int? b)
        {
            return Ok(a-b);
        }
        [HttpPost("[Action]")]
        public IActionResult CalculateMul(int? a,int? b)
        {
            return Ok(a * b);
        }
    }
}
