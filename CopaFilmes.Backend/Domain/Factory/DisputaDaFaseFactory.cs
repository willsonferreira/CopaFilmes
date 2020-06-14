using CopaFilmes.Backend.Domain.Interfaces;
using CopaFilmes.Backend.Model.Interfaces;

namespace CopaFilmes.Backend.Domain.Factory
{
    public static class DisputaDaFaseFactory
    {
        public static IDisputaDaFase Criar(IFase fase)
        {
            return new DisputaDaFase(fase);
        }
    }
}