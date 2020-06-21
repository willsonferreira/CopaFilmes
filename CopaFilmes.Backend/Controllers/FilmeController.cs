using CopaFilmes.Backend.Model;
using CopaFilmes.Backend.Model.Interfaces;
using CopaFilmes.Backend.Model.Factory;
using CopaFilmes.Backend.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Extensions.Options;

namespace CopaFilmes.Backend.Controllers
{
    [ApiController]
    [Route("filme")]
    public class FilmeController : ControllerBase
    {
        private readonly IFontesExternas _fontesExternas; 
        public FilmeController(IOptions<FontesExternas> fontesExternas)
        {
            _fontesExternas = FontesExternasFactory.Criar(fontesExternas);
        }

        [HttpGet]
        public IEnumerable<IFilme> Get()
        {
            var listaDeFilmesService = new ListaDeFilmesService(_fontesExternas);
            return listaDeFilmesService.Buscar();
        }
    }

    
}
