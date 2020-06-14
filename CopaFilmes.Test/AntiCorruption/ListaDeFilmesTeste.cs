using CopaFilmes.Backend.AntiCorruption;
using CopaFilmes.Backend.AntiCorruption.Interfaces;
using NUnit.Framework;

namespace CopaFilmes.Test.AntiCorruption
{
    public class ListaDeFilmesTeste
    {
        public IListaDeFilmes listaDeFilmes;

        [SetUp]
        public void Dado_uma_lista_de_fimles_vazia()
        {
            
        }

        [Test]
        public void Devo_conseguir_preencher_a_lista_buscando_os_itens_na_fonte_de_dados()
        {
            //Arrange
            listaDeFilmes = new ListaDeFilmes();

            //Act
            var retornoComFilmes = listaDeFilmes.Buscar();

            //Assert
            Assert.IsTrue(retornoComFilmes.Count > 0); 
        }
    }
}