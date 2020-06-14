using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using CopaFilmes.Backend.Model.Interfaces;
using CopaFilmes.Backend.Model.Factory;
using CopaFilmes.Backend.Model;
using CopaFilmes.Backend.Service;

namespace CopaFilmes.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CampeonatoController : ControllerBase
    {
        [HttpPost]
        public IResultadoDaFinal Post([FromBody] List<FilmeRecebido> filmes)
        {
            var execucaoDoCampeonatoService = new ExecucaoDoCampeonatoService();
            var filmesConvertidos = filmes.ConvertAll(new Converter<FilmeRecebido, IFilme>(FilmeFactory.Criar));
            var campeonato = execucaoDoCampeonatoService.Executar(filmesConvertidos);

            return campeonato.ResultadoFinal;
        }
    }
}