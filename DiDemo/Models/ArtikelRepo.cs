using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace DiDemo.Models
{
    public class ArtikelRepo : IRepoArtikels
    {

        List<Artikel> li = new List<Artikel>();

        public IEnumerable<Artikel> GetArtikels()
        {           
            using (var db = new ArtikelsDb())
            {
                var repo = db.Artikels.ToList();
                li = repo;
            }
            return li;
        }

         
        // [ValidateAntiForgeryToken]
        public Artikel GetArtikel(int id)
        {
            using (var db = new ArtikelsDb()) {

                return db.Artikels.Where(c => c.Id == id).FirstOrDefault();
            }
        }
    }
}