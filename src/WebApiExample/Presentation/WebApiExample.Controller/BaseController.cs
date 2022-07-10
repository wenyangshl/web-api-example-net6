global using System.Diagnostics.CodeAnalysis;
global using Microsoft.Extensions.Logging;
global using Microsoft.AspNetCore.Mvc;
global using System.Runtime.CompilerServices;
global using Microsoft.AspNetCore.Http;

[assembly: InternalsVisibleTo("WebApiExample")]

namespace WebApiExample.Controller
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    //[Produces("applicaiton/json")]
    [ExcludeFromCodeCoverage]
    public abstract class BaseController : ControllerBase
    {
       
    }
}
