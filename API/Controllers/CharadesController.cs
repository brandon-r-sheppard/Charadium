using System.Net.Http;
using API.Core;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("[controller]")]
    public class CharadesController
    {
        [HttpGet]
        public string Get(){
            CharadeManager m = new CharadeManager();
            return m.RandomCharade;
        }
    }
}