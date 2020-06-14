using CopaFilmes.Backend.Domain.Interfaces;
using CopaFilmes.Backend.Model.Interfaces;

namespace CopaFilmes.Backend.Domain.Factory
{
    public static class ApuracaoDoConfrontoFactory
    {
        public static IApuracaoDoConfronto Criar(IConfronto confronto)
        {
            return new ApuracaoDoConfronto(confronto);
        }
    }
}