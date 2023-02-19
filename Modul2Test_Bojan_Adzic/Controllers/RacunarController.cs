using Microsoft.AspNetCore.Mvc;
using Modul2Test_Bojan_Adzic.Repository.Interfaces;
using Modul2Test_Bojan_Adzic.Repository;
using Modul2Test_Bojan_Adzic.Models;

namespace Modul2Test_Bojan_Adzic.Controllers
{
    public class RacunarController : Controller
    {
        IConfiguration Configuration { get; }
        IRacunarRepository RacunarRepository;

        public RacunarController(IConfiguration Configuration)
        {
            this.Configuration = Configuration;
            this.RacunarRepository = new RacunarRepository(Configuration);
        }
        public IActionResult Index()
        {
            List<Racunar> racunari = RacunarRepository.GetAll();
            return View(racunari);
        }
        public IActionResult Azuriraj(int Id)
        {
            Racunar r = RacunarRepository.GetOne(Id);
            return View(r);
        }

        [HttpPost]
        public IActionResult Azuriraj(Racunar Racunar)
        {
            ModelState.Remove("StudentskiPopust");
            if (!ModelState.IsValid)
            {
                return View(Racunar);
            }
            RacunarRepository.Edit(Racunar);
            List<Racunar> racunari = RacunarRepository.GetAll();
            return View("Index", racunari);
        }

        public IActionResult Dodaj()
        {
            Racunar Racunar = new Racunar();
            return View(Racunar);
        }

        [HttpPost]
        public IActionResult Dodaj(Racunar Racunar)
        {
            ModelState.Remove("StudentskiPopust");
            if (!ModelState.IsValid)
            {
                return View(Racunar);
            }
            RacunarRepository.Create(Racunar);
            List<Racunar> racunari = RacunarRepository.GetAll();
            return View("Index", racunari);
        }
    }
}
