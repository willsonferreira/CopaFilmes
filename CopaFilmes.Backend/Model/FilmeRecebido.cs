using CopaFilmes.Backend.Model.Interfaces;

namespace CopaFilmes.Backend.Model
{
    public class FilmeRecebido: IFilme
    {
        public string Id { get; set; }
        public string Titulo { get; set; }
        public double Nota { get; set; }

        public string AnoLancamento { get; set; }

        public FilmeRecebido()
        {

        }
    }
}
