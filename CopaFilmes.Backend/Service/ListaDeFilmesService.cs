using CopaFilmes.Backend.AntiCorruption;
using CopaFilmes.Backend.Model.Interfaces;
using System.Collections.Generic;

namespace CopaFilmes.Backend.Service
{
    public class ListaDeFilmesService
    {
        private IFontesExternas _fontesExternas { get; set; }

        public ListaDeFilmesService(IFontesExternas fontesExternas)
        {
            _fontesExternas = fontesExternas;
        }
        public IList<IFilme> Buscar()
        {
            var listaDeFilmes = new ListaDeFilmes(_fontesExternas);

            return listaDeFilmes.Buscar();
        }
    }
}
