using CopaFilmes.Backend.Model.Interfaces;
using System;

namespace CopaFilmes.Backend.Model
{
    public class ResultadoDaFinal: IResultadoDaFinal
    {
        #region Propriedades Privadas
        protected IFilme _campeao { get; set; }
        protected IFilme _viceCampeao { get; set; }
        #endregion

        #region Propriedades Publicas
        public IFilme Campeao { get { return _campeao; } }
        public IFilme ViceCampeao { get { return _viceCampeao; } }
        #endregion

        #region Construtor
        public ResultadoDaFinal(IFilme campeao, IFilme viceCampeao)
        {
            if (campeao == null)
                throw new ArgumentNullException("O Campeão não foi informado");

            if (viceCampeao == null)
                throw new ArgumentNullException("O Vice Campeão não foi informado");

            _campeao = campeao;
            _viceCampeao = viceCampeao;
        }
        #endregion

    }
}
