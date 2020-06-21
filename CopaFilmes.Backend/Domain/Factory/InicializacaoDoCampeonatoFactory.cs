using CopaFilmes.Backend.Domain.Interfaces;
using CopaFilmes.Backend.Model.Interfaces;
using System.Collections.Generic;

namespace CopaFilmes.Backend.Domain.Factory
{
    public static class InicializacaoDoCampeonatoFactory
    {
        public static IInicializacaoDoCampeonato Criar(IList<IFilme> participantes, IConfiguracaoDoCampeonato configuracaoDoCampeonato)
        {
            return new InicializacaoDoCampeonato(participantes, configuracaoDoCampeonato);
        }
    }
}