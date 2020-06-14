using CopaFilmes.Backend.Model.Interfaces;

namespace CopaFilmes.Backend.Model.Factory
{
    public static class ResultadoDaFinalFactory
    {
        public static IResultadoDaFinal Criar(IFilme campeao, IFilme viceCampeao)
        {
            return new ResultadoDaFinal(campeao, viceCampeao);
        }
    }
}