using CopaFilmes.Backend.Model.Interfaces;

namespace CopaFilmes.Backend.Model.Factory
{
    public static class ResultadoPartidaFactory
    {
        public static IResultadoDaPartida Criar(IParticipante vencedor, IParticipante derrotado)
        {
            return new ResultadoDaPartida(vencedor, derrotado);
        }
    }
}