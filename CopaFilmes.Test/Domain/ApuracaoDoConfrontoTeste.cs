using CopaFilmes.Backend.Domain;
using CopaFilmes.Backend.Model;
using NUnit.Framework;

namespace CopaFilmes.Test.Domain
{
    public class ApuracaoDoConfrontoTeste
    {
        public ApuracaoDoConfronto apuracaoDoConfronto;

        [SetUp]
        public void Dado_um_confronto()
        {
            
        }

        [Test]
        public void Devo_conseguir_definir_como_vencedor_o_filme_com_maior_nota()
        {
            //Arrange
            var filmeParticipante1 = new Participante(new Filme("1","Filme 1", 10), 1);
            var filmeParticipante2 = new Participante(new Filme("2","Filme 2", 9), 2);
            var confronto = new Confronto(filmeParticipante1, filmeParticipante2, 1);
            
            //Act
            apuracaoDoConfronto = new ApuracaoDoConfronto(confronto);
            var resultadoDaPartida = apuracaoDoConfronto.DefinirVencedor();

            //Assert
            Assert.IsTrue(resultadoDaPartida.Vencedor.FilmeParticipante.Nota > resultadoDaPartida.Derrotado.FilmeParticipante.Nota); 
        }

        [Test]
        public void Devo_conseguir_definir_o_vencedor_pela_ordem_alfabetica_quando_acontecer_empate_por_nota()
        {
            //Arrange
            var filmeParticipante1 = new Participante(new Filme("1","Filme 1", 10), 2);
            var filmeParticipante2 = new Participante(new Filme("2","Filme 2", 10), 1);
            var confronto = new Confronto(filmeParticipante1, filmeParticipante2, 1);
            
            //Act
            apuracaoDoConfronto = new ApuracaoDoConfronto(confronto);
            var resultadoDaPartida = apuracaoDoConfronto.DefinirVencedor();

            //Assert
            Assert.IsTrue(resultadoDaPartida.Vencedor.PosicaoNaOrdemAlfabetica < resultadoDaPartida.Derrotado.PosicaoNaOrdemAlfabetica); 
        }
    }
}