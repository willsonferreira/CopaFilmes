namespace CopaFilmes.Backend.Model.Interfaces
{
    public interface IConfronto
    {        
        public IParticipante Participante1 { get; }
        public IParticipante Participante2 { get ; }

        public int PosicaoDoConfrontoNaFase { get; }

    }
}
