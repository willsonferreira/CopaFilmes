using CopaFilmes.Backend.Model.Interfaces;
using System.Collections.Generic;

namespace CopaFilmes.Backend.Model
{
    public class Fase: IFase
    {
        #region Propriedades Privadas
        protected List<IConfronto> _confrontos { get; set; }
        #endregion

        #region Propriedades Publicas
        public IList<IConfronto> Confrontos { get { return _confrontos.AsReadOnly(); } }
        #endregion

        #region Construtores
        public Fase()
        {
            if (_confrontos == null)
                _confrontos = new List<IConfronto>();
        }
        #endregion

        #region Metodos
        public IList<IConfronto> AdicionarConfronto(IConfronto confronto)
        {
            _confrontos.Add(confronto);

            return Confrontos;
        }
        #endregion
    }
}
