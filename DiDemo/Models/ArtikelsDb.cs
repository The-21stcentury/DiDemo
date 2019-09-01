using System.Data.Entity;

namespace DiDemo.Models

{
    public class ArtikelsDb : DbContext
    {
        public DbSet<Artikel> Artikels { get; set; }
    }
}