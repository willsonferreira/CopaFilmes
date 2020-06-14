using CopaFilmes.Backend.Model.Interfaces;

namespace CopaFilmes.Backend.Model.Factory
{
    public static class FilmeFactory
    {
        public static IFilme Criar(string id, string titulo, double nota, string anoLancamento = null)
        {
            return new Filme(id, titulo, nota, anoLancamento);
        }

        public static IFilme Criar(FilmeRecebido filmeRecebido)
        {
            return new Filme(filmeRecebido.Id, filmeRecebido.Titulo, filmeRecebido.Nota, filmeRecebido.AnoLancamento);
        }
    }
}