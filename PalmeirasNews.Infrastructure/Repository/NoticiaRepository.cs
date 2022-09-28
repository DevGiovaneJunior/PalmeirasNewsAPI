using PalmeirasNews.Infrastructure.Data;
using PalmeirasNews.Domain.Entities;
using PalmeirasNews.Infrastructure.Repository.Interfaces;

namespace PalmeirasNews.Infrastructure.Repository
{
    public class NoticiaRepository : BaseRepository<Noticia>, INoticiaRepository
    {
        public readonly Context _context;
        public NoticiaRepository(Context Context)
            : base(Context)
        {
            _context = Context;
        }
    }
}
