using CopaFilmes.Backend.Domain.Factory;
using CopaFilmes.Backend.Model.Interfaces;
using CopaFilmes.Backend.Model.Factory;
using CopaFilmes.Backend.Model;
using NUnit.Framework;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace CopaFilmes.Test.Domain
{
    public class DisputaDaFinalTeste
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
        public void Devo_conseguir_executar_o_confronto_da_final()
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

            var disputaDoCampeonato = DisputaDoCampeonatoFactory.Criar(campeonato);
            disputaDoCampeonato.ExecutarDisputaDasFases();
            
            //Act
            var disputaDaFinal = DisputaDaFinalFactory.Criar(campeonato);
            disputaDaFinal.ExecutarConfrontoDaFinal();

            //Assert
            Assert.AreEqual(campeonato.ResultadoFinal.Campeao.Titulo, listaDeFilmes[0].Titulo); 
        }
    }
}