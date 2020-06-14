using CopaFilmes.Backend.Domain.Factory;
using CopaFilmes.Backend.Model.Interfaces;
using System.Collections.Generic;

namespace CopaFilmes.Backend.Service
{
    public class ExecucaoDoCampeonatoService
    {
        public ICampeonato Executar(IList<IFilme> filmes)
        {
            var inicializacaoDoCampeonato = InicializacaoDoCampeonatoFactory.Criar(filmes);

            var campeonato = inicializacaoDoCampeonato.Inicializar();

            var dispitaDoCampeonato = DisputaDoCampeonatoFactory.Criar(campeonato);
            dispitaDoCampeonato.ExecutarDisputaDasFases();

            var dispitaDaFinal = DisputaDaFinalFactory.Criar(campeonato);
            dispitaDaFinal.ExecutarConfrontoDaFinal();

            return campeonato;
        }
    }
}
