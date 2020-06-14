using CopaFilmes.Backend.Domain;
using CopaFilmes.Backend.Model.Factory;
using CopaFilmes.Backend.Model.Interfaces;
using NUnit.Framework;
using System.Collections.Generic;

namespace CopaFilmes.Test.Domain
{
    public class InicializacaoDosParticipantesTeste
    {
        private List<IFilme> listaDeFilmes;

        [SetUp]
        public void Dado_uma_lista_de_filmes()
        {
            
        }

        [Test]
        public void Devo_conseguir_inicializar_a_lista_dos_participantes_ordenados_em_ordem_alfabetica()
        {
            //Arrange
            listaDeFilmes = new List<IFilme>();
            var filmeParticipante1 = FilmeFactory.Criar("1","Filme 2", 10);
            listaDeFilmes.Add(filmeParticipante1);
            var filmeParticipante2 = FilmeFactory.Criar("2","Filme 4", 9);
            listaDeFilmes.Add(filmeParticipante2);
            var filmeParticipante3 = FilmeFactory.Criar("1","Filme 3", 10);
            listaDeFilmes.Add(filmeParticipante3);
            var filmeParticipante4 = FilmeFactory.Criar("2","Filme 1", 9);
            listaDeFilmes.Add(filmeParticipante4);
            
            //Act
            var inicializacaoDosParticipantes = new InicializacaoDosParticipantes(listaDeFilmes);
            var participantes = inicializacaoDosParticipantes.Inicializar();

            //Assert
            Assert.AreEqual(participantes[0].FilmeParticipante.Titulo, "Filme 1"); 
        }
    }
}