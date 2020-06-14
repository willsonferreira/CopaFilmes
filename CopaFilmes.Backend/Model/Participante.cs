using CopaFilmes.Backend.Model.Interfaces;
using System;

namespace CopaFilmes.Backend.Model
{
    public class Participante: IParticipante
    {
        #region Propriedades Privadas
        protected IFilme _filmeParticipante { get; set; }
        protected int _posicaoNaOrdemAlfabetica { get; set; }
        #endregion

        #region Propriedades Publicas
        public IFilme FilmeParticipante { get { return _filmeParticipante; } }

        public int PosicaoNaOrdemAlfabetica { get { return _posicaoNaOrdemAlfabetica; } }
        #endregion

        #region Construtores
        public Participante(IFilme filmeParticipante, int posicaoNaOrdemAlfabetica)
        {
            if(filmeParticipante == null)
                throw new ArgumentNullException("Filme participante não informado");

            if(posicaoNaOrdemAlfabetica <= 0)
                throw new ArgumentException("Posição na ordem alfabetica inválida");

            _filmeParticipante = filmeParticipante;
            _posicaoNaOrdemAlfabetica = posicaoNaOrdemAlfabetica;
        }
        #endregion
    }
}
