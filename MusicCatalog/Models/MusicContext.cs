using Microsoft.EntityFrameworkCore;
using MusicCatalog.Models;

namespace MusicCatalog.Data
{
    public class MusicContext(DbContextOptions<MusicContext> options) : DbContext(options)
    {
        public DbSet<Music> Musics { get; set; }
    }
}