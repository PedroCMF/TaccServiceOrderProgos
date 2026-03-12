using Microsoft.AspNetCore.Mvc;
using Tacc.serviceOrder.Application.DTOs.Requests;
using Tacc.serviceOrder.Application.DTOs.Responses;

namespace Tacc.serviceOrder.Api.Controllers
{
   // [Route("Api/[controller]")]
    //[ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)] //data annotation para indicar que o método retorna um status 200 OK se estiver tudo ok
    public class AuthController : BaseController //o BaseController tem a rota, tem ApiController tem a classe ControllerBase
    {

        //public AcceptedResult teste() //a classe BaseEntity é abstrata, ou seja, não pode ser instanciada, por isso o teste da erro
        //{
        //    BaseEntity x = new BaseEntity(); //sem o abstrato funciona desde ele fica dentro do metodo teste, erro daquele dia
        //    x.Id = 1;
        //    x.Date = DateTime.Now;
        //    x.active = true;
        //    return Accepted(x);
        //}

       // [HttpGet]
        //public IActionResult Login([FromHeader] int id, [FromHeader] string email, [FromHeader] string password) //cria no swegger(front) as o formulario com as string email e sennha. O [FromRoute] indica que os parâmetros serão passados pela rota, ou seja, na URL, por exemplo. o string  indica que o tipo do parâmetro é string, ou seja, texto, e o nome do parâmetro é email e password, ou seja, senha. O IActionResult indica que o método retorna um resultado de ação, ou seja, uma resposta HTTP, como por exemplo 200 OK, 400 Bad Request, etc.
        //{
        //    //VALIDAR EMAIL E SENHA
        //    //A CONTROLER SO RECEBE REQUEST, E DEPOIS CHAMA O SERVIÇO PARA VALIDAR O EMAIL E A SENHA, SE ESTIVER TUDO OK, O SERVIÇO RETORNA OK
        //    //SO RETORNA RESPONSE OK SE O SERVIÇO RETORNAR OK, SE O SERVIÇO RETORNAR ERRO, A CONTROLER RETORNA BAD REQUEST, OU SE FOR UM ERRO DE AUTENTICAÇÃO, RETORNA UNAUTHORIZED
        //    return Ok(new { message = "Ok email e senha", Token = "sadasasfsfsafsafsafsafsaffffff6565as6as6" });
        //}


        [HttpPost] //recebe email e senha, atraves da api vai no banco e valida e devolve uma resposta
        //request recebe email e senha, ou seja, os dados de login, e o método Login é responsável por validar esses dados e retornar um token de autenticação se estiver tudo ok. O [FromBody] indica que os parâmetros serão passados no corpo da requisição, ou seja, no JSON, e o RequestLoginJson é a classe que representa o JSON, ou seja, tem as propriedades Email e Password, que são as mesmas do JSON. O IActionResult indica que o método retorna um resultado de ação, ou seja, uma resposta HTTP, como por exemplo 200 OK, 400 Bad Request, etc.
        public IActionResult Login(RequestLoginJson request) //indica que os parâmetros serão passados no corpo da requisição, ou seja, no JSON, e o RequestLoginJson é a classe que vai receber os dois valores do JSON, ou seja, email e senha, e o método Login é responsável por validar esses dados e retornar um token,
        {
            var response =  new ResponseTokenJson(); //cria  uma instancia para usar a classe ResponseTokenJson, que tem a propriedade Token,

            return Ok(response); //retorna a reposta do token e ok, ou seja, 200 OK, e o token no corpo da resposta, que é o que o cliente espera receber quando fizer a requisição de login, ou seja, o token de autenticação para acessar os recursos protegidos da API.
        }


    }
}
