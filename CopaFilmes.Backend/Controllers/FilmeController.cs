using CopaFilmes.Backend.Model.Interfaces;
using CopaFilmes.Backend.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CopaFilmes.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<IFilme> Get()
        {
            var listaDeFilmesService = new ListaDeFilmesService();
            return listaDeFilmesService.Buscar();
        }
    }

    
}
