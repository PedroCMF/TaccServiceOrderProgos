using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Tacc.serviceOrder.Api.Controllers
{
   // [Route("api/[controller]")]
    //[ApiController]
    public class ProductController : BaseController
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

    }
}
