using CopaFilmes.Backend.Model.Interfaces;
using System;

namespace CopaFilmes.Backend.Model
{
    public class ResultadoDaPartida: IResultadoDaPartida
    {
        #region Propriedades Privadas

        protected IParticipante _vencedor { get; set; }
        protected IParticipante _derrotado { get; set; }
        #endregion

        #region Propriedades Publicas
        public IParticipante Vencedor { get { return _vencedor; } }
        public IParticipante Derrotado { get { return _derrotado; } }
        #endregion

        #region Construtor
        public ResultadoDaPartida(IParticipante vencedor, IParticipante derrotado)
        {
            if (vencedor == null)
                throw new ArgumentNullException("O Vencedor não foi informado");

            if (derrotado == null)
                throw new ArgumentNullException("O Derrotado não foi informado");

            _vencedor = vencedor;
            _derrotado = derrotado;
        }
        #endregion
    }
}
