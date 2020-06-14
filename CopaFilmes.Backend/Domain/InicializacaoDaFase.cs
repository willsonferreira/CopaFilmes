using CopaFilmes.Backend.Domain.Interfaces;
using CopaFilmes.Backend.Model.Factory;
using CopaFilmes.Backend.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CopaFilmes.Backend.Domain
{
    public class InicializacaoDaFase : IInicializacaoDaFase
    {
        #region Propriedades Privadas
        protected IFase _fase { get; set; }
        protected List<IParticipante> _participantes { get; set; }
        #endregion

        #region Propriedades Publicas
        public IFase Fase { get { return _fase; } }
        public IList<IParticipante> Participantes { get { return _participantes.AsReadOnly(); } }
        #endregion

        #region Construtores
        public InicializacaoDaFase(IList<IParticipante> participantes, IFase fase = null)
        {
            if (participantes == null)
                throw new ArgumentNullException("Os filmes participantes não foram informados");

            if (participantes.Count % 2 != 0)
                throw new ArgumentException("Quantidade de participantes deve ser par");

            if (fase == null)
                fase = FaseFactory.Criar();

            _fase = fase;
            _participantes = participantes.ToList();
        }
        #endregion

        #region Metodos
        public IFase Inicializar()
        {
            int primeiraPosicao = 1;
            int ultimaPosicao = _participantes.OrderBy(participanteSelecionado => participanteSelecionado.PosicaoNaOrdemAlfabetica).Last().PosicaoNaOrdemAlfabetica;
            int posicaoDoConfrontoNaFase = 1;
            while (ultimaPosicao - primeiraPosicao > 0)
            {
                IParticipante participante1 = BuscarParticipantePorPosicaoNaOrdemAlfabetica(primeiraPosicao);
                IParticipante participante2 = BuscarParticipantePorPosicaoNaOrdemAlfabetica(ultimaPosicao);
                var confronto = ConfrontoFactory.Criar(participante1, participante2, posicaoDoConfrontoNaFase);

                _fase.AdicionarConfronto(confronto);

                primeiraPosicao++;
                ultimaPosicao--;
                posicaoDoConfrontoNaFase++;
            }
            return _fase;
        }

        private IParticipante BuscarParticipantePorPosicaoNaOrdemAlfabetica(int posicaoNaOrdemAlfabetica)
        {
            IParticipante participante = _participantes.First(particimante => particimante.PosicaoNaOrdemAlfabetica == posicaoNaOrdemAlfabetica);

            return participante;
        }
        #endregion
    }
}
