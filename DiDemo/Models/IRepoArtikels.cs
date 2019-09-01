using System.Collections.Generic;
namespace DiDemo.Models
{
    public interface IRepoArtikels
    {
        IEnumerable<Artikel> GetArtikels();

        Artikel GetArtikel(int id);
    }
}