
using CopaFilmes.Backend.Domain.Factory;
using CopaFilmes.Backend.Model.Interfaces;
using CopaFilmes.Backend.Model.Factory;
using NUnit.Framework;
using System.Collections.Generic;

namespace CopaFilmes.Test.Domain
{
    public class DisputaDoCampeonatoTeste
    {
        public ICampeonato campeonato;

        [SetUp]
        public void Dado_um_campeonato()
        {
            
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
            
            var inicializacaoDoCampeonato = InicializacaoDoCampeonatoFactory.Criar(listaDeFilmes);
            campeonato = inicializacaoDoCampeonato.Inicializar();
            
            //Act
            var disputaDoCampeonato = DisputaDoCampeonatoFactory.Criar(campeonato);
            campeonato = disputaDoCampeonato.ExecutarDisputaDasFases();

            //Assert
            Assert.Greater(campeonato.Fases.Count, 1); 
        }
    }
}