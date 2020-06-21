using CopaFilmes.Backend.Model.Interfaces;
using CopaFilmes.Backend.Model.Factory;
using CopaFilmes.Backend.Model;
using CopaFilmes.Backend.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.Extensions.Options;

namespace CopaFilmes.Backend.Controllers
{
    [ApiController]
    [Route("quantidade-de-participantes-permitidos")]
    public class QuantidadeDeParticipantesPermitidosController : ControllerBase
    {
        private readonly IConfiguracaoDoCampeonato _configuracaoDoCampeonato; 
        public QuantidadeDeParticipantesPermitidosController(IOptions<ConfiguracaoDoCampeonato> configuracaoDoCampeonato)
        {
            _configuracaoDoCampeonato = ConfiguracaoDoCampeonatoFactory.Criar(configuracaoDoCampeonato);
        }

        [HttpGet]
        public int Get()
        {
            return _configuracaoDoCampeonato.QuantidadeDeFilmesPermitidos;
        }
    }
}