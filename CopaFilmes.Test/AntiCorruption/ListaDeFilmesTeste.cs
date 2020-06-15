using CopaFilmes.Backend.AntiCorruption;
using CopaFilmes.Backend.AntiCorruption.Interfaces;
using CopaFilmes.Backend.Model;
using CopaFilmes.Backend.Model.Interfaces;
using NUnit.Framework;
using Microsoft.Extensions.Configuration;

namespace CopaFilmes.Test.AntiCorruption
{
    public class ListaDeFilmesTeste
    {
        private IListaDeFilmes listaDeFilmes;
        private IFontesExternas fontesExternas;

        [SetUp]
        public void Dado_uma_lista_de_fimles_vazia()
        {
            var config = new ConfigurationBuilder()
            .AddJsonFile("appSettings.json")
            .Build();
            
            fontesExternas = config.GetSection("FontesExternas").Get<FontesExternas>();   
        }

        [Test]
        public void Devo_conseguir_preencher_a_lista_buscando_os_itens_na_fonte_de_dados()
        {
            //Arrange
            listaDeFilmes = new ListaDeFilmes(fontesExternas);

            //Act
            var retornoComFilmes = listaDeFilmes.Buscar();

            //Assert
            Assert.IsTrue(retornoComFilmes.Count > 0); 
        }
    }
}