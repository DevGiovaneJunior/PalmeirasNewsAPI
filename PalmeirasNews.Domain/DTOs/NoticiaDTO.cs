using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalmeirasNews.Domain.DTOs
{
    public class NoticiaDTO
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Noticia { get; set; }
        public int? INT_ID_IMAGEM { get; set; }
    }
}
