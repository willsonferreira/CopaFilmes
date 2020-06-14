using CopaFilmes.Backend.Service;
using NUnit.Framework;

namespace CopaFilmes.Test.Service
{
    public class ListaDeFilmesServiceTeste
    {
        public ListaDeFilmesService listaDeFilmesService;

        [SetUp]
        public void Dado_um_servico_de_lista_de_filmes()
        {
            
        }

        [Test]
        public void Devo_conseguir_buscar_os_filmes_na_fonte_de_dados()
        {
            //Arrange
            listaDeFilmesService = new ListaDeFilmesService();

            //Act
            var retornoComFilmes = listaDeFilmesService.Buscar();

            //Assert
            Assert.IsTrue(retornoComFilmes.Count > 0); 
        }
    }
}