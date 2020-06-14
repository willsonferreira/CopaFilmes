using CopaFilmes.Backend.Model.Interfaces;

namespace CopaFilmes.Backend.Domain.Interfaces
{
    public interface IDisputaDaFase
    {
        IFase AvancarFase(IFase novaFase);
    }
}
