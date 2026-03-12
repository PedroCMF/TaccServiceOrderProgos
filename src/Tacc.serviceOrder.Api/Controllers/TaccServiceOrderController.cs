using Microsoft.AspNetCore.Mvc;

namespace Tacc.serviceOrder.Api.Controllers
{
    //[Route("api/[controller]")] //o controller é TaccServiceOrder
   // [ApiController]
    public class TaccServiceOrderController : BaseController
    {
        [HttpGet]//atributo para definir que o método é do tipo GET
        //EndPoint para verificar se o serviço está rodando
        public IActionResult Get() //Metodo(EndPoint) get do tipo IActionResult
        {
            return Ok(new {message = "Tacc ServiceOrder está rodando", Date = DateTime.UtcNow } ); //cria um retorno com  duas mensagens 

        }

    }
}
