using CopaFilmes.Backend.Model.Interfaces;
using CopaFilmes.Backend.Model.Factory;
using CopaFilmes.Backend.Model;
using CopaFilmes.Backend.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Options;


namespace CopaFilmes.Backend.Controllers
{
    [ApiController]
    [Route("campeonato")]
    public class CampeonatoController : ControllerBase
    {
        private readonly IConfiguracaoDoCampeonato _configuracaoDoCampeonato; 
        public CampeonatoController(IOptions<ConfiguracaoDoCampeonato> configuracaoDoCampeonato)
        {
            _configuracaoDoCampeonato = ConfiguracaoDoCampeonatoFactory.Criar(configuracaoDoCampeonato);
        }

        [HttpPost]
        public IResultadoDaFinal Post([FromBody] List<FilmeRecebido> filmes)
        {
            var execucaoDoCampeonatoService = new ExecucaoDoCampeonatoService(_configuracaoDoCampeonato);
            var filmesConvertidos = filmes.ConvertAll(new Converter<FilmeRecebido, IFilme>(FilmeFactory.Criar));
            var campeonato = execucaoDoCampeonatoService.Executar(filmesConvertidos);

            return campeonato.ResultadoFinal;
        }
    }
}