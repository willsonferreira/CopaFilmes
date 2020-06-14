namespace CopaFilmes.Backend.Model.Interfaces
{
    public interface IResultadoDaPartida
    {
        public IParticipante Vencedor { get; }
        public IParticipante Derrotado { get; }
    }
}
