using CopaFilmes.Backend.Domain;
using CopaFilmes.Backend.Model.Factory;
using CopaFilmes.Backend.Model.Interfaces;
using NUnit.Framework;

namespace CopaFilmes.Test.Domain
{
    public class DisputaDaFaseTeste
    {
        public IFase fase;

        [SetUp]
        public void Dado_uma_fase()
        {
            
        }

        [Test]
        public void Devo_conseguir_avancar_a_fase_executando_as_disputas_dos_conforntos()
        {
            //Arrange
            var filmeParticipante1 = ParticipanteFactory.Criar(FilmeFactory.Criar("1","Filme 1", 10), 1);
            var filmeParticipante2 = ParticipanteFactory.Criar(FilmeFactory.Criar("2","Filme 2", 9), 2);
            var confronto1 = ConfrontoFactory.Criar(filmeParticipante1, filmeParticipante2, 1);

            var filmeParticipante3 = ParticipanteFactory.Criar(FilmeFactory.Criar("1","Filme 3", 10), 3);
            var filmeParticipante4 = ParticipanteFactory.Criar(FilmeFactory.Criar("2","Filme 4", 9), 4);
            var confronto2 = ConfrontoFactory.Criar(filmeParticipante3, filmeParticipante4, 2);

            fase = FaseFactory.Criar();
            fase.AdicionarConfronto(confronto1);
            fase.AdicionarConfronto(confronto2);

            IFase novaFase = FaseFactory.Criar();            
            //Act
            var disputaDaFase = new DisputaDaFase(fase);
            novaFase = disputaDaFase.AvancarFase(novaFase);

            //Assert
            Assert.AreEqual(novaFase.Confrontos.Count, 1); 
        }
    }
}