using CopaFilmes.Backend.AntiCorruption;
using CopaFilmes.Backend.AntiCorruption.Interfaces;
using NUnit.Framework;

namespace CopaFilmes.Test
{
    public class ListaDeFilmesTeste
    {
        public IListaDeFilmes listaDeFilmes;

        [SetUp]
        public void Daado_Uma_ListaDeFimlesVazia()
        {
            listaDeFilmes = new ListaDeFilmes();
        }

        [Test]
        public void Devo_conseguir_preencher_a_lista_buscando_os_itens_na_fonte_de_dados()
        {
            var retornoComFilmes = listaDeFilmes.Buscar();

            Assert.IsTrue(retornoComFilmes.Count > 0); 
        }
    }
}