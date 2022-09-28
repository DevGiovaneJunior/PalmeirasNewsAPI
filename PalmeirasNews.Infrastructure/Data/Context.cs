using Microsoft.EntityFrameworkCore;
using PalmeirasNews.Domain.Entities;

namespace PalmeirasNews.Infrastructure.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Noticia> Noticia { get; set; }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
