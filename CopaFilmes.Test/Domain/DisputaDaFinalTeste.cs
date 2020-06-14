
using CopaFilmes.Backend.Domain.Factory;
using CopaFilmes.Backend.Model.Interfaces;
using CopaFilmes.Backend.Model.Factory;
using NUnit.Framework;
using System.Collections.Generic;

namespace CopaFilmes.Test.Domain
{
    public class DisputaDaFinalTeste
    {
        public ICampeonato campeonato;

        [SetUp]
        public void Dado_um_campeonato()
        {
            
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
            
            var inicializacaoDoCampeonato = InicializacaoDoCampeonatoFactory.Criar(listaDeFilmes);
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