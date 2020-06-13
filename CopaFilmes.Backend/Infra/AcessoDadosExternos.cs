using System;
using System.Net.Http;

namespace CopaFilmes.Backend.Infra
{
    public class AcessoDadosExternos
    {
        #region Propriedades Privadas
        protected string _url { get; set; }
        #endregion

        #region Construtores
        public AcessoDadosExternos(string url)
        {
            if (string.IsNullOrEmpty(url))
                throw new ArgumentNullException("A url deve ser informada");

            _url = url;
        }
        #endregion

        #region Metodos
        public string BuscarDadosComoTexto()
        {
            try
            {
                var client = new HttpClient();
                var response = client.GetStringAsync(_url);

                return response.Result;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

    }
}
