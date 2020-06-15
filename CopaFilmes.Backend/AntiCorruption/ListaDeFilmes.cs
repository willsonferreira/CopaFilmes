using CopaFilmes.Backend.AntiCorruption.Interfaces;
using CopaFilmes.Backend.Infra;
using CopaFilmes.Backend.Model.Factory;
using CopaFilmes.Backend.Model.Interfaces;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace CopaFilmes.Backend.AntiCorruption
{    
    public class ListaDeFilmes : IListaDeFilmes
    {
        #region Propriedades Privadas
        protected IFontesExternas _fontesExternas { get; set; }
        #endregion

        #region Construtores
        public ListaDeFilmes(IFontesExternas fontesExternas)
        {
            _fontesExternas = fontesExternas;
        }
        #endregion

        #region Metodos
        public IList<IFilme> Buscar()
        {
            var acessoDadosExternos = new AcessoDadosExternos(_fontesExternas.UrlFilmes);

            var jsonFilmes = acessoDadosExternos.BuscarDadosComoTexto();

            var filmesDynanmics = JArray.Parse(jsonFilmes);

            List<IFilme> filmes = new List<IFilme>();

            foreach (dynamic filmeDynamic in filmesDynanmics)
            {
                string id = filmeDynamic.id;
                string titulo = filmeDynamic.titulo;
                string notaTexto = filmeDynamic.nota;
                double nota = double.Parse(notaTexto, System.Globalization.CultureInfo.InvariantCulture);
                string anoLancamento = filmeDynamic.ano;

                var filme = FilmeFactory.Criar(id, titulo, nota, anoLancamento);
                filmes.Add(filme);
            }

            return filmes;
        }
        #endregion
    }
}
