using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CopaFilmes.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class  Controller : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "sucesso";
        }
    }

    
}
