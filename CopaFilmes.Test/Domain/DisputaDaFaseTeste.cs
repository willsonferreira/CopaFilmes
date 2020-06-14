using CopaFilmes.Backend.Domain;
using CopaFilmes.Backend.Model;
using CopaFilmes.Backend.Model.Interfaces;
using NUnit.Framework;

namespace CopaFilmes.Test.Domain
{
    public class DisputaDaFaseTeste
    {
        public Fase fase;

        [SetUp]
        public void Dado_uma_fase()
        {
            
        }

        [Test]
        public void Devo_conseguir_executar_as_disputas_dos_conforntos()
        {
            //Arrange
            var filmeParticipante1 = new Participante(new Filme("1","Filme 1", 10), 1);
            var filmeParticipante2 = new Participante(new Filme("2","Filme 2", 9), 2);
            var confronto1 = new Confronto(filmeParticipante1, filmeParticipante2, 1);

            var filmeParticipante3 = new Participante(new Filme("1","Filme 3", 10), 3);
            var filmeParticipante4 = new Participante(new Filme("2","Filme 4", 9), 4);
            var confronto2 = new Confronto(filmeParticipante3, filmeParticipante4, 2);

            fase = new Fase();
            fase.AdicionarConfronto(confronto1);
            fase.AdicionarConfronto(confronto2);

            IFase novaFase = new Fase();

            
            //Act
            var disputaDaFase = new DisputaDaFase(fase);
            novaFase = disputaDaFase.AvancarFase(novaFase);

            //Assert
            Assert.AreEqual(novaFase.Confrontos.Count, 1); 
        }
    }
}