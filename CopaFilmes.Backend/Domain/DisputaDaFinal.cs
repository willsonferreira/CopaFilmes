using CopaFilmes.Backend.Domain.Interfaces;
using CopaFilmes.Backend.Domain.Factory;
using CopaFilmes.Backend.Model.Interfaces;
using CopaFilmes.Backend.Model.Factory;
using System;
using System.Linq;

namespace CopaFilmes.Backend.Domain
{
    public class DisputaDaFinal: IDisputaDaFinal
    {
        #region Propriedades Privadas
        protected ICampeonato _campeonato;
        #endregion

        #region Propriedades Publicas
        public ICampeonato Campeonato { get { return _campeonato; } }
        #endregion

        #region Construtores
        public DisputaDaFinal(ICampeonato campeonato)
        {
            if (campeonato == null)
                throw new ArgumentNullException("Campeonato não informado");

            _campeonato = campeonato;
        }
        #endregion

        #region Metodos
        public ICampeonato ExecutarConfrontoDaFinal()
        {
            var confrontoFinal = _campeonato.Fases.Where(fase => fase.Confrontos.Count == 1).FirstOrDefault().Confrontos.FirstOrDefault();
            var apuracaoDoConfronto = ApuracaoDoConfrontoFactory.Criar(confrontoFinal);
            var resultadoDaPartida = apuracaoDoConfronto.DefinirVencedor();
            var resultadoDaFinal = ResultadoDaFinalFactory.Criar(resultadoDaPartida.Vencedor.FilmeParticipante, resultadoDaPartida.Derrotado.FilmeParticipante);

            _campeonato.AdicionarResultadoDaFinal(resultadoDaFinal);

            return _campeonato;
        }
        #endregion
    }
}
