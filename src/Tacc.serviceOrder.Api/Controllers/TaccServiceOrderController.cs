using Microsoft.AspNetCore.Mvc;

namespace Tacc.serviceOrder.Api.Controllers
{
<<<<<<< HEAD
    //[Route("api/[controller]")] //o controller é TaccServiceOrder
   // [ApiController]
    public class TaccServiceOrderController : BaseController
=======
    [Route("api/[controller]")] //o controller é TaccServiceOrder
    [ApiController]
    public class TaccServiceOrderController : ControllerBase
>>>>>>> a890a364e4b1bd7f486f40dedfb44e9d3b4e6cd6
    {
        [HttpGet]//atributo para definir que o método é do tipo GET
        //EndPoint para verificar se o serviço está rodando
        public IActionResult Get() //Metodo(EndPoint) get do tipo IActionResult
        {
            return Ok(new {message = "Tacc ServiceOrder está rodando", Date = DateTime.UtcNow } ); //cria um retorno com  duas mensagens 

        }

    }
}
