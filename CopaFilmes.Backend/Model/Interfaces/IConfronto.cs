namespace CopaFilmes.Backend.Model.Interfaces
{
    public interface IConfronto
    {        
        IParticipante Participante1 { get; }
        IParticipante Participante2 { get ; }

        int PosicaoDoConfrontoNaFase { get; }

    }
}
