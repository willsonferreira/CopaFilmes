using CopaFilmes.Backend.Domain.Factory;
using CopaFilmes.Backend.Model.Interfaces;
using System.Collections.Generic;

namespace CopaFilmes.Backend.Service
{
    public class ExecucaoDoCampeonatoService
    {
        private IConfiguracaoDoCampeonato _configuracaoDoCampeonato;
        public ExecucaoDoCampeonatoService(IConfiguracaoDoCampeonato configuracaoDoCampeonato)
        {
            _configuracaoDoCampeonato = configuracaoDoCampeonato;
        }
        public ICampeonato Executar(IList<IFilme> filmes)
        {
            var inicializacaoDoCampeonato = InicializacaoDoCampeonatoFactory.Criar(filmes, _configuracaoDoCampeonato);

            var campeonato = inicializacaoDoCampeonato.Inicializar();

            var dispitaDoCampeonato = DisputaDoCampeonatoFactory.Criar(campeonato);
            dispitaDoCampeonato.ExecutarDisputaDasFases();

            var dispitaDaFinal = DisputaDaFinalFactory.Criar(campeonato);
            dispitaDaFinal.ExecutarConfrontoDaFinal();

            return campeonato;
        }
    }
}
