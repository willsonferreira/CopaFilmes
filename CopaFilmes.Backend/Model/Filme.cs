using CopaFilmes.Backend.Model.Interfaces;
using System;

namespace CopaFilmes.Backend.Model
{
    public class Filme : IFilme
    {
        #region Propriedades Privadas
        private string _id { get; set; }
        private string _titulo { get; set; }
        private double _nota { get; set; }
        private string _anoLancamento { get; set; }
        #endregion

        #region Propriedades Publicas
        public string Id { get { return _id; } }
        public string Titulo { get { return _titulo; } }
        public double Nota { get { return _nota; } }
        public string AnoLancamento { get { return _anoLancamento; } }
        #endregion

        #region Construtores
        public Filme()
        {

        }

        public Filme(string id, string titulo, double nota, string anoLancamento = null)
        {
            if (string.IsNullOrEmpty(id))
                throw new ArgumentException("Id não informado");

            if (string.IsNullOrEmpty(titulo))
                throw new ArgumentNullException("Título não informado");

            if (nota < 0)
                throw new ArgumentException("A nota deve ser maior que zero");

            _id = id;
            _titulo = titulo;
            _nota = nota;
            _anoLancamento = anoLancamento;
        }
        #endregion
    }
}
