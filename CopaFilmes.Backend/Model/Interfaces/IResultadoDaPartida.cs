namespace CopaFilmes.Backend.Model.Interfaces
{
    public interface IResultadoDaPartida
    {
        IParticipante Vencedor { get; }
        IParticipante Derrotado { get; }
    }
}
