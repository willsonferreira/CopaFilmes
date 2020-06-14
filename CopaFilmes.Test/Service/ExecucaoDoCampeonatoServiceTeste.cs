using CopaFilmes.Backend.Service;
using CopaFilmes.Backend.Model.Interfaces;
using CopaFilmes.Backend.Model.Factory;
using NUnit.Framework;
using System.Collections.Generic;

namespace CopaFilmes.Test.Service
{
    public class ExecucaoDoCampeonatoServiceTeste
    {
        private List<IFilme> listaDeFilmes;

        [SetUp]
        public void Dado_uma_lista_de_filmes()
        {
            
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
            var execucaoDoCampeonatoService = new ExecucaoDoCampeonatoService();
            var campeonato = execucaoDoCampeonatoService.Executar(listaDeFilmes);

            //Assert
            Assert.AreEqual(campeonato.ResultadoFinal.Campeao.Titulo, listaDeFilmes[0].Titulo); 
        }
    }
}