using DiDemo.Models;
using DiDemo.ModelView;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;

namespace DiDemo.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;
        private IRepoArtikels _repo;
        public HomeController(ILogger<HomeController> logger, IRepoArtikels repo)
        {
            _logger = logger;
            _repo = repo;
        }

        public IActionResult Index()
        {
            ViewBag.Header = "DI Web!";

            var model = new List<ArtikelsViewModels>();

            var dbArtikels = _repo.GetArtikels();
            foreach(var dbArtikel in dbArtikels)
            {
                var vm = new ArtikelsViewModels
                {
                    Id = dbArtikel.Id,
                    Ueberschrift = dbArtikel.Ueberschrift,
                    //Artikel = dbArtikel.ShortArtikel,
                };

                model.Add(vm);
            }

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
        //[HttpPost] 

        [Route("/Home/GetArtikel/{id:int}")] 
        public IActionResult GetArtikel(int Id)
        {                    
            var artikel = new ArtikelsViewModels();
            var item = _repo.GetArtikel(Id);
            artikel.Artikel = item.ShortArtikel;
            artikel.Id = item.Id;
            artikel.Ueberschrift = item.Ueberschrift;
            return View(artikel);       
        } 
        public ArtikelsViewModels Mod { get; set; }
    }
}