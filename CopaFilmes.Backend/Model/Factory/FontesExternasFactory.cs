using CopaFilmes.Backend.Model.Interfaces;
using Microsoft.Extensions.Options;

namespace CopaFilmes.Backend.Model.Factory
{
    public static class FontesExternasFactory
    {
        public static IFontesExternas Criar(IOptions<FontesExternas> fontesExternas)
        {
            return new FontesExternas(fontesExternas.Value.UrlFilmes);
        }
    }
}