using CopaFilmes.Backend.Model.Interfaces;

namespace CopaFilmes.Backend.Domain.Interfaces
{
    public interface IApuracaoDoConfronto
    {
        IResultadoDaPartida DefinirVencedor();
    }
}
