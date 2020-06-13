using CopaFilmes.Backend.Model;
using CopaFilmes.Backend.Model.Interfaces;
using CopaFilmes.Backend.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CopaFilmes.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ListaDeFilmesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<IFilme> Get()
        {
            var listaDeFilmesService = new ListaDeFilmesService();
            return listaDeFilmesService.Buscar();
        }
    }

    
}
