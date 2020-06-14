
using CopaFilmes.Backend.Domain.Interfaces;
using CopaFilmes.Backend.Model.Interfaces;

namespace CopaFilmes.Backend.Domain.Factory
{
    public static class DisputaDaFinalFactory
    {
        public static IDisputaDaFinal Criar(ICampeonato campeonato)
        {
            return new DisputaDaFinal(campeonato);
        }
    }
}