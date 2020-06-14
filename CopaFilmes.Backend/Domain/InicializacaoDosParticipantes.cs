using CopaFilmes.Backend.Domain.Interfaces;
using CopaFilmes.Backend.Model.Interfaces;
using CopaFilmes.Backend.Model.Factory;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CopaFilmes.Backend.Domain
{
    public class InicializacaoDosParticipantes: IInicializacaoDosParticipantes
    {
        #region Propriedades Privadas
        protected List<IFilme> _filmesParticipantes { get; set; }
        #endregion

        #region Propriedades Publicas
        public IList<IFilme> FilmesParticipantes { get { return _filmesParticipantes.AsReadOnly(); } }
        #endregion

        #region Construtores
        public InicializacaoDosParticipantes(IList<IFilme> filmesParticipantes)
        {
            if (filmesParticipantes == null)
                throw new ArgumentNullException("Os filmes participantes não foram informados");

            _filmesParticipantes = filmesParticipantes.ToList();
        }
        #endregion

        #region Metodos
        public IList<IParticipante> Inicializar()
        {
            IList<IParticipante> participantes = new List<IParticipante>();
            int posicaoNaOrdemAlfabetica = 1;

            foreach (var filme in _filmesParticipantes.OrderBy(filme => filme.Titulo))
            {
                var participante = ParticipanteFactory.Criar(filme, posicaoNaOrdemAlfabetica);
                participantes.Add(participante);
                posicaoNaOrdemAlfabetica++;
            }

            return participantes;
        }
        #endregion
    }
}
