using CopaFilmes.Backend.Model.Interfaces;

namespace CopaFilmes.Backend.Model
{
    public class FontesExternas: IFontesExternas
    {
        public string UrlFilmes { get; set; }

        public FontesExternas()
        {

        }

        public FontesExternas(string urlFilmes)
        {
            UrlFilmes = urlFilmes;
        }
    } 
} 