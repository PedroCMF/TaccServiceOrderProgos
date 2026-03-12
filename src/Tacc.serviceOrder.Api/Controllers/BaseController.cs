using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Tacc.serviceOrder.Api.Controllers
{
    [Route("v2/[controller]")]
    [ApiController]
    //Usa o abstract para não pode ser instanciada, ou seja, não pode ser criada um objeto dessa classe, ou seja, não pode ser criada uma variável do tipo dessa classe, ou seja, não pode ser criado um new BaseController(), ou seja, essa classe é apenas para ser herdada por outras classes, ou seja, para ser usada como base para outras classes, ou seja, para ser usada como superclasse para outras classes, ou seja, para ser usada como classe pai para outras classes
    public abstract class BaseController : ControllerBase // controller BaseController que herada da classe ControllerBase, ou seja, os outros controllers vão herdar dessa classe, ou seja, vão ser filhos dessa classe, ou seja, vão ter acesso aos métodos e propriedades dessa classe
    {


    }
}
