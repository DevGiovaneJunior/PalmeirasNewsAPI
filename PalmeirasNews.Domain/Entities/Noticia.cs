using PalmeirasNews.Domain.Validations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PalmeirasNews.Domain.Entities
{
    public class Noticia
    {
        public int Id { get; private set; }
        public string Titulo { get; private set; }
        public string noticia { get; private set; }
        public int? INT_ID_IMAGEM { get; private set; }
        public Noticia(string titulo, string noticia)
        {
            Validation(titulo, noticia);
        }
        public Noticia(int id, string titulo, string noticia, int iNT_ID_IMAGEM)
        {
            DomainValidationException.When(id < 0, "id deve ser maior que zero!");
            Id = id;
            Validation(titulo, noticia);
            INT_ID_IMAGEM = iNT_ID_IMAGEM;
        }
        private void Validation(string titulo, string Noticia)
        {
            DomainValidationException.When(string.IsNullOrEmpty(titulo), "titulo deve ser informado!");
            DomainValidationException.When(string.IsNullOrEmpty(Noticia), "noticia deve ser informado!");

            Titulo = titulo;
            noticia = Noticia;
        }
    }
}
