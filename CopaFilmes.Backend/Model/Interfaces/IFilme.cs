namespace CopaFilmes.Backend.Model.Interfaces
{
    public interface IFilme
    {
        string Id {  get; }
        string Titulo { get; }
         double Nota { get; }
         string AnoLancamento { get; }
    }
}
