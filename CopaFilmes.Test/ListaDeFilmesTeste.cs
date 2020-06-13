using System.Net.Http;
using NUnit.Framework;

namespace CopaFilmes.Test
{
    public class ListaDeFilmesTeste
    {

        [SetUp]
        public void Daado_Uma_ListaDeFimlesVazia()
        {
        }

        [Test]
        public void Devo_conseguir_preencher_a_lista_buscando_os_itens_na_fonte_de_dados()
        {
            var url = "http://copafilmes.azurewebsites.net/api/filmes";
            var client = new HttpClient();
                var response = client.GetStringAsync(url);

            var listaDeFilmes = response.Result;

            Assert.IsNotEmpty(listaDeFilmes); 
        }
    }
}