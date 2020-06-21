using CopaFilmes.Backend.Model.Interfaces;
using Microsoft.Extensions.Options;

namespace CopaFilmes.Backend.Model.Factory
{
    public static class ConfiguracaoDoCampeonatoFactory
    {
        public static IConfiguracaoDoCampeonato Criar(IOptions<ConfiguracaoDoCampeonato> configuracaoDoCampeonato)
        {
            return new ConfiguracaoDoCampeonato(configuracaoDoCampeonato.Value.QuantidadeDeFilmesPermitidos);
        }
    }
}