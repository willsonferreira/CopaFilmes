using CopaFilmes.Backend.Domain.Interfaces;
using CopaFilmes.Backend.Model.Interfaces;
using System.Collections.Generic;

namespace CopaFilmes.Backend.Domain.Factory
{
    public static class InicializacaoDaFaseFactory
    {
        public static IInicializacaoDaFase Criar(IList<IParticipante> participantes)
        {
            return new InicializacaoDaFase(participantes);
        }
    }
}