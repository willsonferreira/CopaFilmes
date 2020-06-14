using CopaFilmes.Backend.Model;
using CopaFilmes.Backend.Model.Interfaces;

namespace CopaFilmes.Backend.Model.Factory
{
    public static class FaseFactory
    {
        public static IFase Criar()
        {
            return new Fase();
        }
    }
}