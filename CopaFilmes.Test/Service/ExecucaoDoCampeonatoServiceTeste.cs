using CopaFilmes.Backend.Service;
using CopaFilmes.Backend.Model.Interfaces;
using CopaFilmes.Backend.Model.Factory;
using CopaFilmes.Backend.Model;
using NUnit.Framework;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace CopaFilmes.Test.Service
{
    public class ExecucaoDoCampeonatoServiceTeste
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
        public void Devo_conseguir_executar_o_campeonato_e_definir_o_campeao()
        {
            //Arrange
            listaDeFilmes = new List<IFilme>();
            IFilme filmeParticipante;

            filmeParticipante = FilmeFactory.Criar("10", $"Filme 10", 10);
            listaDeFilmes.Add(filmeParticipante);
            
            for (int i = 1; i <= 7; i++)
            {
                filmeParticipante = FilmeFactory.Criar(i.ToString(), $"Filme {i}", 9);
                listaDeFilmes.Add(filmeParticipante);
            }            
            
            //Act
            var execucaoDoCampeonatoService = new ExecucaoDoCampeonatoService(configuracaoDoCampeonato);
            var campeonato = execucaoDoCampeonatoService.Executar(listaDeFilmes);

            //Assert
            Assert.AreEqual(campeonato.ResultadoFinal.Campeao.Titulo, listaDeFilmes[0].Titulo); 
        }
    }
}