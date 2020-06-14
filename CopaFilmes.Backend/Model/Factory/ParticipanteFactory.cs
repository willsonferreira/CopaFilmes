using CopaFilmes.Backend.Model;
using CopaFilmes.Backend.Model.Interfaces;

namespace CopaFilmes.Backend.Model.Factory
{
    public static class ParticipanteFactory
    {
        public static IParticipante Criar(IFilme filme, int posicaoNaOrdemAlfabetica)
        {
            return new Participante(filme, posicaoNaOrdemAlfabetica);
        }
    }
}