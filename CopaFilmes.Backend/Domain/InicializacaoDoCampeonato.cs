using CopaFilmes.Backend.Domain.Interfaces;
using CopaFilmes.Backend.Domain.Factory;
using CopaFilmes.Backend.Model.Factory;
using CopaFilmes.Backend.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CopaFilmes.Backend.Domain
{
    public class InicializacaoDoCampeonato: IInicializacaoDoCampeonato
    {
        #region Propriedades Privadas
        protected List<IFilme> _filmesParticipantes;
        #endregion

        #region Propriedades Publicas
        public IList<IFilme> FilmesParticipantes { get { return _filmesParticipantes.AsReadOnly(); } }
        #endregion

        #region Construtores
        public InicializacaoDoCampeonato(IList<IFilme> filmesParticipantes, IConfiguracaoDoCampeonato configuracaoDoCampeonato)
        {
            if (filmesParticipantes == null)
                throw new ArgumentNullException("Os filmes participantes não foram informados");

            if (filmesParticipantes.Count != configuracaoDoCampeonato.QuantidadeDeFilmesPermitidos)
                throw new ArgumentException($"Devem ser informados {configuracaoDoCampeonato.QuantidadeDeFilmesPermitidos} filmes participantes");

            _filmesParticipantes = filmesParticipantes.ToList();
        }
        #endregion

        #region Metodos
        public ICampeonato Inicializar()
        {
            var inicializacaoDosParticipantes = InicializacaoDosParticipantesFactory.Criar(FilmesParticipantes);
            var participantes = inicializacaoDosParticipantes.Inicializar();

            var inicializacaoDaFase = InicializacaoDaFaseFactory.Criar(participantes);

            var faseInicial = inicializacaoDaFase.Inicializar();

            var campeonato = CampeonatoFactory.Criar(participantes, faseInicial);

            return campeonato;
        }
        #endregion
    }
}
