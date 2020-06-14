using CopaFilmes.Backend.Model.Interfaces;
using System.Collections.Generic;

namespace CopaFilmes.Backend.Model.Factory
{
    public static class CampeonatoFactory
    {
        public static ICampeonato Criar(IList<IParticipante> participantes, IFase faseInicial)
        {
            return new Campeonato(participantes, faseInicial);
        }
    }
}