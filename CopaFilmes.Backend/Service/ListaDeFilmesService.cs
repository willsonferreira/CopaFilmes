using CopaFilmes.Backend.AntiCorruption;
using CopaFilmes.Backend.Model.Interfaces;
using System.Collections.Generic;

namespace CopaFilmes.Backend.Service
{
    public class ListaDeFilmesService
    {
        public IList<IFilme> Buscar()
        {
            var listaDeFilmes = new ListaDeFilmes();

            return listaDeFilmes.Buscar();
        }
    }
}
