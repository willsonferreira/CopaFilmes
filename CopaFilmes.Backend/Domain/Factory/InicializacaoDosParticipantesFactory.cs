using CopaFilmes.Backend.Domain.Interfaces;
using CopaFilmes.Backend.Model.Interfaces;
using System.Collections.Generic;

namespace CopaFilmes.Backend.Domain.Factory
{
    public static class InicializacaoDosParticipantesFactory
    {
        public static IInicializacaoDosParticipantes Criar(IList<IFilme> filmesParticipantes)
        {
            return new InicializacaoDosParticipantes(filmesParticipantes);
        }
    }
}