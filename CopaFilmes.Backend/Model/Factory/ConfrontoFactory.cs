using CopaFilmes.Backend.Model;
using CopaFilmes.Backend.Model.Interfaces;

namespace CopaFilmes.Backend.Model.Factory
{
    public static class ConfrontoFactory
    {
        public static IConfronto Criar(IParticipante participante1, IParticipante participante2, int posicaoDoConfrontoNaFase)
        {
            return new Confronto(participante1, participante2, posicaoDoConfrontoNaFase);
        }
    }
}