using CopaFilmes.Backend.Service;
using CopaFilmes.Backend.Model;
using CopaFilmes.Backend.Model.Interfaces;
using NUnit.Framework;
using Microsoft.Extensions.Configuration;

namespace CopaFilmes.Test.Service
{
    public class ListaDeFilmesServiceTeste
    {
        private string _url { get; set; }
        private ListaDeFilmesService listaDeFilmesService;
        private IFontesExternas fontesExternas { get; set; }

        [SetUp]
        public void Dado_um_servico_de_lista_de_filmes()
        {
            var config = new ConfigurationBuilder()
            .AddJsonFile("appSettings.json")
            .Build();
            
            fontesExternas = config.GetSection("FontesExternas").Get<FontesExternas>();
        }

        [Test]
        public void Devo_conseguir_buscar_os_filmes_na_fonte_de_dados()
        {
            //Arrange
            listaDeFilmesService = new ListaDeFilmesService(fontesExternas);

            //Act
            var retornoComFilmes = listaDeFilmesService.Buscar();

            //Assert
            Assert.IsTrue(retornoComFilmes.Count > 0); 
        }
    }
}