using CopaFilmes.Backend.Model.Interfaces;

namespace CopaFilmes.Backend.Model
{
    public class ConfiguracaoDoCampeonato: IConfiguracaoDoCampeonato
    {
        public int QuantidadeDeFilmesPermitidos { get; set; }

        public ConfiguracaoDoCampeonato()
        {

        }

        public ConfiguracaoDoCampeonato(int quantidadeDeFilmesPermitidos)
        {
            QuantidadeDeFilmesPermitidos = quantidadeDeFilmesPermitidos;
        }
    } 
} 