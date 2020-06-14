using CopaFilmes.Backend.Model.Interfaces;
using System;

namespace CopaFilmes.Backend.Model
{
    public class Confronto: IConfronto
    {
        #region Propriedades Privadas
        protected IParticipante _participante1 { get; set; }
        protected IParticipante _participante2 { get; set; }
        protected int _posicaoDoConfrontoNaFase { get; set; }
        #endregion

        #region Propriedades Publicas
        public IParticipante Participante1 { get { return _participante1; } }
        public IParticipante Participante2 { get { return _participante2; } }
        public int PosicaoDoConfrontoNaFase { get { return _posicaoDoConfrontoNaFase; } }
        #endregion

        #region Construtores
        public Confronto(IParticipante participante1, IParticipante participante2, int posicaoDoConfrontoNaFase)
        {
            if (participante1 == null || participante2 == null)
                throw new ArgumentNullException("Os participantes não foran informados");

            if (posicaoDoConfrontoNaFase <= 0)
                throw new ArgumentException("Posição do confronto na fase inválida");

            _participante1 = participante1;
            _participante2 = participante2;
            _posicaoDoConfrontoNaFase = posicaoDoConfrontoNaFase;
        }
        #endregion

    }
}
