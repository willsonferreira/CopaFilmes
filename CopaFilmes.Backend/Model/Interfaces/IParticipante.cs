namespace CopaFilmes.Backend.Model.Interfaces
{
    public interface IParticipante
    {
        public IFilme FilmeParticipante { get; }

        public int PosicaoNaOrdemAlfabetica { get; }
    }
}
