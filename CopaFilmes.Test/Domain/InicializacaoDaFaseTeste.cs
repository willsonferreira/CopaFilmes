using CopaFilmes.Backend.Domain;
using CopaFilmes.Backend.Model.Factory;
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
            
            for (int i = 1; i <= 8; i++)
            {
                var filmeParticipante = ParticipanteFactory.Criar(FilmeFactory.Criar(i.ToString(), $"Filme {i}", i), i);
                listaDeParticipantes.Add(filmeParticipante);
            }            

            IFase novaFase;
            
            //Act
            var inicializacaoDaFase = new InicializacaoDaFase(listaDeParticipantes);
            novaFase = inicializacaoDaFase.Inicializar();

            //Assert
            Assert.AreEqual(novaFase.Confrontos.Count,4); 
        }
    }
}