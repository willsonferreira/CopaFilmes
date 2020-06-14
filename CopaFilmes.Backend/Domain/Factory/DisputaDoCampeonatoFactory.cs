using CopaFilmes.Backend.Domain.Interfaces;
using CopaFilmes.Backend.Model.Interfaces;

namespace CopaFilmes.Backend.Domain.Factory
{
    public static class DisputaDoCampeonatoFactory
    {
        public static IDisputaDoCampeonato Criar(ICampeonato campeonato)
        {
            return new DisputaDoCampeonato(campeonato);
        }
    }
}