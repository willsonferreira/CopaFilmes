using CopaFilmes.Backend.Domain;
using CopaFilmes.Backend.Model;
using CopaFilmes.Backend.Model.Interfaces;
using NUnit.Framework;
using System.Collections.Generic;

namespace CopaFilmes.Test.Domain
{
    public class InicializacaoDoCampeonatoTeste
    {
        private List<IFilme> listaDeFilmes;

        [SetUp]
        public void Dado_uma_lista_de_filmes()
        {
            
        }

        [Test]
        public void Devo_conseguir_inicializar_o_campeonato_configurando_a_fase_inicial()
        {
            //Arrange
            listaDeFilmes = new List<IFilme>();
            for (int i = 1; i <= 8; i++)
            {
                var filmeParticipante = new Filme(i.ToString(), $"Filme {i}", 10);
                listaDeFilmes.Add(filmeParticipante);
            }            
            
            //Act
            var inicializacaoDosParticipantes = new InicializacaoDoCampeonato(listaDeFilmes);
            var campeonato = inicializacaoDosParticipantes.Inicializar();

            //Assert
            Assert.AreEqual(campeonato.Fases.Count,1); 
        }
    }
}