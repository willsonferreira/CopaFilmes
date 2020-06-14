using System.Collections.Generic;

namespace CopaFilmes.Backend.Model.Interfaces
{
    public interface IFase
    {
        IList<IConfronto> Confrontos { get; }
        IList<IConfronto> AdicionarConfronto(IConfronto confronto);
    }
}
