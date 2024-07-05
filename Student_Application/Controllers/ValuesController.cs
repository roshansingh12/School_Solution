using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Student_Application.Controllers
{
    [Route("Student_api/[controller]")]//token -> [controller] "this will be changed on run time."
    //which is called token replacement.
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("[Action]")]
        public ActionResult<int> CalculateSum(int? a, int? b)
        {
            return a + b;
        }
        //[HttpGet("[Action]")]
        [HttpGet("[Action]/api/{a}")]//this is attribute routing
        //attribute routing has two types of attributes : static attributes, dynamic attributes
        //{a}-> dynamic, /api/->static
        public ActionResult<int> CalculateSub(int? a,int? b)
        {
            return Ok(a - b);
        }
        [HttpGet("[Action]")]
        public IActionResult CalculateMul(int? a,int? b)
        {
            return Ok(a*b);
        }
        //multiple urls can target to single resource
        //single url can only target to one resource.
    }
}
