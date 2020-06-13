using CopaFilmes.Backend.Model.Interfaces;
using System.Collections.Generic;

namespace CopaFilmes.Backend.AntiCorruption.Interfaces
{
    public interface IListaDeFilmes
    {
        IList<IFilme> Buscar();
    }
}
