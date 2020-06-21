using CopaFilmes.Backend.Domain.Factory;
using CopaFilmes.Backend.Model.Interfaces;
using CopaFilmes.Backend.Model.Factory;
using CopaFilmes.Backend.Model;
using NUnit.Framework;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace CopaFilmes.Test.Domain
{
    public class DisputaDoCampeonatoTeste
    {
        public ICampeonato campeonato;
        private IConfiguracaoDoCampeonato configuracaoDoCampeonato;

        [SetUp]
        public void Dado_um_campeonato()
        {
            
            var config = new ConfigurationBuilder()
            .AddJsonFile("appSettings.json")
            .Build();

            configuracaoDoCampeonato = config.GetSection("ConfiguracaoDoCampeonato").Get<ConfiguracaoDoCampeonato>();
        }

        [Test]
        public void Devo_conseguir_executar_a_disputa_das_fases()
        {
            //Arrange
            var listaDeFilmes = new List<IFilme>();
            for (int i = 1; i <= 8; i++)
            {
                var filmeParticipante = FilmeFactory.Criar(i.ToString(), $"Filme {i}", 10);
                listaDeFilmes.Add(filmeParticipante);
            }   
            
            var inicializacaoDoCampeonato = InicializacaoDoCampeonatoFactory.Criar(listaDeFilmes, configuracaoDoCampeonato);
            campeonato = inicializacaoDoCampeonato.Inicializar();
            
            //Act
            var disputaDoCampeonato = DisputaDoCampeonatoFactory.Criar(campeonato);
            disputaDoCampeonato.ExecutarDisputaDasFases();

            //Assert
            Assert.Greater(campeonato.Fases.Count, 1); 
        }
    }
}