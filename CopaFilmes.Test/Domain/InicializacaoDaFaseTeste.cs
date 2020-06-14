using CopaFilmes.Backend.Domain;
using CopaFilmes.Backend.Model;
using CopaFilmes.Backend.Model.Interfaces;
using NUnit.Framework;
using System.Collections.Generic;

namespace CopaFilmes.Test.Domain
{
    public class InicializacaoDaFaseTeste
    {
        private List<IParticipante> listaDeParticipantes;

        [SetUp]
        public void Dado_uma_lista_de_participantes()
        {
            
        }

        [Test]
        public void Devo_conseguir_inicializar_a_fase_organizando_os_confrontos()
        {
            //Arrange
            listaDeParticipantes = new List<IParticipante>();
            var filmeParticipante1 = new Participante(new Filme("1","Filme 1", 10), 1);
            listaDeParticipantes.Add(filmeParticipante1);
            var filmeParticipante2 = new Participante(new Filme("2","Filme 2", 9), 2);
            listaDeParticipantes.Add(filmeParticipante2);
            var filmeParticipante3 = new Participante(new Filme("1","Filme 3", 10), 3);
            listaDeParticipantes.Add(filmeParticipante3);
            var filmeParticipante4 = new Participante(new Filme("2","Filme 4", 9), 4);
            listaDeParticipantes.Add(filmeParticipante4);

            IFase novaFase;
            
            //Act
            var inicializacaoDaFase = new InicializacaoDaFase(listaDeParticipantes);
            novaFase = inicializacaoDaFase.Inicializar();

            //Assert
            Assert.AreEqual(novaFase.Confrontos.Count,2); 
        }
    }
}