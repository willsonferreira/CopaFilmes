namespace CopaFilmes.Backend.Model.Interfaces
{
    public interface IParticipante
    {
        IFilme FilmeParticipante { get; }

        int PosicaoNaOrdemAlfabetica { get; }
    }
}
