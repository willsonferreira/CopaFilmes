using CopaFilmes.Backend.Domain.Interfaces;
using CopaFilmes.Backend.Factory;
using CopaFilmes.Backend.Model.Interfaces;
using System;

namespace CopaFilmes.Backend.Domain
{
    public class ApuracaoDoConfronto: IApuracaoDoConfronto
    {
        #region Propriedades Privadas
        protected IConfronto _confronto { get; set; }
        #endregion

        #region Propriedades Publicas
        public IConfronto Confronto { get { return _confronto; } }
        #endregion

        #region Construtores
        public ApuracaoDoConfronto(IConfronto confronto)
        {
            if (confronto == null)
                throw new ArgumentException("Confronto não informado");

            _confronto = confronto;
        }
        #endregion

        #region Metodos
        public IResultadoDaPartida DefinirVencedor()
        {
            IResultadoDaPartida resultadoDaPartida;
            IParticipante participante1 = _confronto.Participante1;
            IParticipante participante2 = _confronto.Participante2;

            if (participante1.FilmeParticipante.Nota == participante2.FilmeParticipante.Nota)
                if (participante1.PosicaoNaOrdemAlfabetica < participante2.PosicaoNaOrdemAlfabetica)
                    resultadoDaPartida = ResultadoPartidaFactory.Criar(participante1, participante2);
                else
                    resultadoDaPartida = ResultadoPartidaFactory.Criar(participante2, participante1);
            else if (participante1.FilmeParticipante.Nota > participante2.FilmeParticipante.Nota)
                resultadoDaPartida = ResultadoPartidaFactory.Criar(participante1, participante2);
            else
                resultadoDaPartida = ResultadoPartidaFactory.Criar(participante2, participante1);

            return resultadoDaPartida;
        }
        #endregion
    }
}
