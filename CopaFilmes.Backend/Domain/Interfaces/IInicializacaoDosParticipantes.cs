using CopaFilmes.Backend.Model.Interfaces;
using System.Collections.Generic;

namespace CopaFilmes.Backend.Domain.Interfaces
{
    public interface IInicializacaoDosParticipantes
    {
        IList<IParticipante> Inicializar();
    }
}
