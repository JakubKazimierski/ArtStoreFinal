using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StronaPrototyp.Models;

namespace StronaPrototyp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        List<PaintingsViewModel> paintings;
        List<SoldPaintingsModel> soldPaintings;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

            paintings = new List<PaintingsViewModel>();
            soldPaintings = new List<SoldPaintingsModel>();

            #region Available
            paintings.Add(new PaintingsViewModel("Angel", "crayons", "Beata Kazimierska", 500, "~/content/Aktualne/angel.jpg"));
            paintings.Add(new PaintingsViewModel("Visible", "crayons","Beata Kazimierska",550, "~/content/Aktualne/auto.jpg"));
            paintings.Add(new PaintingsViewModel("Autumn", "paint and crayons", "Beata Kazimierska", 400, "~/content/Aktualne/autumn.jpg"));
            paintings.Add(new PaintingsViewModel("Beach", "paint and crayons", "Beata Kazimierska", 400, "~/content/Aktualne/beach.jpg"));
            paintings.Add(new PaintingsViewModel("Cage", "crayons", "Beata Kazimierska", 400, "~/content/Aktualne/cage.jpg"));
            paintings.Add(new PaintingsViewModel("Nature", "crayons", "Beata Kazimierska", 500, "~/content/Aktualne/dead.jpg"));
            paintings.Add(new PaintingsViewModel("Desire", "crayons", "Beata Kazimierska", 400, "~/content/Aktualne/desire.jpg"));
            paintings.Add(new PaintingsViewModel("Donkey", "crayons", "Beata Kazimierska", 500, "~/content/Aktualne/donkey.jpg"));
            paintings.Add(new PaintingsViewModel("Freedom", "paint and crayons", "Beata Kazimierska", 400, "~/content/Aktualne/freedom.jpg"));
            paintings.Add(new PaintingsViewModel("Life", "paint and crayons", "Beata Kazimierska", 600, "~/content/Aktualne/guideMe.jpg"));
            paintings.Add(new PaintingsViewModel("Landscape", "paint", "Beata Kazimierska", 400, "~/content/Aktualne/landscape.jpg"));
            paintings.Add(new PaintingsViewModel("Noir", "paint", "Beata Kazimierska", 700, "~/content/Aktualne/noir.jpg"));
            paintings.Add(new PaintingsViewModel("Pink", "paint and crayons", "Beata Kazimierska", 650, "~/content/Aktualne/pink.jpg"));
            paintings.Add(new PaintingsViewModel("Sea", "paint and crayons", "Beata Kazimierska", 650, "~/content/Aktualne/sea.jpg"));
            paintings.Add(new PaintingsViewModel("Spring", "crayons", "Beata Kazimierska", 500, "~/content/Aktualne/spring.jpg"));
            paintings.Add(new PaintingsViewModel("Trip", "paint and crayons", "Beata Kazimierska", 700, "~/content/Aktualne/trip.jpg"));
            paintings.Add(new PaintingsViewModel("Wild Garden", "paint and crayons", "Beata Kazimierska", 600, "~/content/Aktualne/wildGarden.jpg"));
            paintings.Add(new PaintingsViewModel("Mountain", "paint and crayons", "Beata Kazimierska", 400, "~/content/Aktualne/banzai2.jpg"));
            paintings.Add(new PaintingsViewModel("Face", "paint and crayons", "Beata Kazimierska", 450, "~/content/Aktualne/Face.png"));
            paintings.Add(new PaintingsViewModel("Hunt", "paint and crayons", "Beata Kazimierska", 400, "~/content/Aktualne/Fan.png"));
            paintings.Add(new PaintingsViewModel("Papilon", "paint and crayons", "Beata Kazimierska", 550, "~/content/Aktualne/Papilon.png"));
            #endregion

            #region sold
            soldPaintings.Add(new SoldPaintingsModel("Archangel", "paint and crayons", "Beata Kazimierska", 700, "~/content/Sprzedane/michal.png"));
            soldPaintings.Add(new SoldPaintingsModel("Abstraction", "oil paint", "Beata Kazimierska", 650, "~/content/Sprzedane/abstraction.png"));
            soldPaintings.Add(new SoldPaintingsModel("Night lake", "paint and crayons", "Beata Kazimierska", 500, "~/content/Sprzedane/nocneJezioro.png"));
            soldPaintings.Add(new SoldPaintingsModel("Garden", "paint and crayons", "Beata Kazimierska", 400, "~/content/Sprzedane/ogrod.png"));
            soldPaintings.Add(new SoldPaintingsModel("Rose", "crayons", "Beata Kazimierska", 300, "~/content/Sprzedane/rose.png"));
            soldPaintings.Add(new SoldPaintingsModel("Melancholy", "paint and crayons", "Beata Kazimierska", 400, "~/content/Sprzedane/skrzypce.png"));
            soldPaintings.Add(new SoldPaintingsModel("Night walk", "paint and crayons", "Beata Kazimierska", 800, "~/content/Sprzedane/Spacer.png"));
            soldPaintings.Add(new SoldPaintingsModel("Freedom", "paint and crayons", "Beata Kazimierska", 600, "~/content/Sprzedane/Wolnosc.png"));
            soldPaintings.Add(new SoldPaintingsModel("World", "paint and crayons", "Beata Kazimierska", 700, "~/content/Sprzedane/world.png"));
            soldPaintings.Add(new SoldPaintingsModel("Yellow Rose", "paint and crayons", "Beata Kazimierska", 400, "~/content/Sprzedane/zoltaRoza.png"));
            soldPaintings.Add(new SoldPaintingsModel("Archangel", "paint and crayons", "Beata Kazimierska", 400, "~/content/Sprzedane/Michael.png"));
            #endregion
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Paintings()
        {
            return View(paintings);
        }

        public IActionResult Author()
        {
            return View();
        }

        public IActionResult Sold()
        {
            return View(soldPaintings);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
