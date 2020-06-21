using CopaFilmes.Backend.Domain.Factory;
using CopaFilmes.Backend.Model.Factory;
using CopaFilmes.Backend.Model.Interfaces;
using CopaFilmes.Backend.Model;
using NUnit.Framework;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace CopaFilmes.Test.Domain
{
    public class InicializacaoDoCampeonatoTeste
    {
        private List<IFilme> listaDeFilmes;
        private IConfiguracaoDoCampeonato configuracaoDoCampeonato;

        [SetUp]
        public void Dado_uma_lista_de_filmes()
        {
            var config = new ConfigurationBuilder()
            .AddJsonFile("appSettings.json")
            .Build();
            
            configuracaoDoCampeonato = config.GetSection("ConfiguracaoDoCampeonato").Get<ConfiguracaoDoCampeonato>();
        }

        [Test]
        public void Devo_conseguir_inicializar_o_campeonato_configurando_a_fase_inicial()
        {
            //Arrange
            listaDeFilmes = new List<IFilme>();
            for (int i = 1; i <= 8; i++)
            {
                var filmeParticipante = FilmeFactory.Criar(i.ToString(), $"Filme {i}", 10);
                listaDeFilmes.Add(filmeParticipante);
            }            
            
            //Act
            var inicializacaoDosParticipantes = InicializacaoDoCampeonatoFactory.Criar(listaDeFilmes, configuracaoDoCampeonato);
            var campeonato = inicializacaoDosParticipantes.Inicializar();

            //Assert
            Assert.AreEqual(campeonato.Fases.Count,1); 
        }
    }
}