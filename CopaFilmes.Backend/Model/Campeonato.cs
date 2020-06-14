using CopaFilmes.Backend.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CopaFilmes.Backend.Model
{
    public class Campeonato: ICampeonato
    {
        #region Propriedades Privadas
        protected List<IFase> _fases { get; set; }
        protected List<IParticipante> _participantes { get; set; }

        protected IResultadoDaFinal _resultadoDaFinal { get; set; }
        #endregion

        #region Propriedades Publicas
        public IList<IFase> Fases { get { return _fases.AsReadOnly(); } }
        public IList<IParticipante> Participantes { get { return _participantes.AsReadOnly(); } }
        public IResultadoDaFinal ResultadoFinal { get { return _resultadoDaFinal; } }
        #endregion

        #region Construtores
        public Campeonato(IList<IParticipante> participantes, IFase faseInicial)
        {
            if (faseInicial == null)
                throw new ArgumentNullException("Fase inicial não foi informada");

            if (participantes == null)
                throw new ArgumentNullException("Os participantes não foram informados");

            if (participantes.Count != 8)
                throw new ArgumentException("Quantidade de participantes inválida");

            if (_fases == null)
                _fases = new List<IFase>();

            _fases.Add(faseInicial);
            _participantes = participantes.ToList();

        }
        #endregion

        #region Metodos
        public IList<IFase> AdicionarFase(IFase fase)
        {
            _fases.Add(fase);

            return Fases;
        }

        public IResultadoDaFinal AdicionarResultadoDaFinal(IResultadoDaFinal resultadoDaFinal)
        {
            _resultadoDaFinal = resultadoDaFinal;

            return _resultadoDaFinal;
        }
        #endregion
    }
}
