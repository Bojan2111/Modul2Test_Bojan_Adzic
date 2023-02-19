using Microsoft.AspNetCore.Mvc;
using Modul2Test_Bojan_Adzic.Repository.Interfaces;
using Modul2Test_Bojan_Adzic.Repository;
using Modul2Test_Bojan_Adzic.ViewModels;
using Modul2Test_Bojan_Adzic.Models;

namespace Modul2Test_Bojan_Adzic.Controllers
{
    public class KomponentaController : Controller
    {
        IConfiguration Configuration { get; }
        IKomponentaRepository KomponentaRepository;

        public KomponentaController(IConfiguration Configuration)
        {
            this.Configuration = Configuration;
            this.KomponentaRepository = new KomponentaRepository(Configuration);
        }
        public IActionResult Index(int RacunarId)
        {
            KomponentaKomponente kkvm = new KomponentaKomponente();
            kkvm.Komponenta = new Komponenta();
            kkvm.RacunarId= RacunarId;
            kkvm.Komponenta.RacunarId = RacunarId;
            kkvm.Komponente = KomponentaRepository.GetAll(RacunarId);
            return View(kkvm);
        }

        public IActionResult Obrisi(int Id, int RacunarId)
        {
            KomponentaRepository.Delete(Id);
            KomponentaKomponente kkvm = new KomponentaKomponente();
            kkvm.Komponenta = new Komponenta();
            kkvm.RacunarId = RacunarId;
            kkvm.Komponenta.RacunarId = RacunarId;
            kkvm.Komponente = KomponentaRepository.GetAll(RacunarId);
            return View("Index", kkvm);
        }
        [HttpPost]
        public IActionResult Dodaj(Komponenta Komponenta, int RacunarId)
        {
            //Komponenta.RacunarId = RacunarId;
            KomponentaRepository.Create(Komponenta);
            KomponentaKomponente kkvm = new KomponentaKomponente();
            kkvm.Komponenta = new Komponenta();
            kkvm.RacunarId = RacunarId;
            kkvm.Komponenta.RacunarId = RacunarId;
            kkvm.Komponente = KomponentaRepository.GetAll(RacunarId);
            return View("Index", kkvm);
        }

        public IActionResult Ovogodisnje(int RacunarId)
        {
            KomponentaKomponente kkvm = new KomponentaKomponente();
            kkvm.Komponenta = new Komponenta();
            kkvm.RacunarId = RacunarId;
            kkvm.Komponenta.RacunarId = RacunarId;
            kkvm.Komponente = KomponentaRepository.Ovogodisnje(RacunarId);
            return View("Index", kkvm);
        }
        public IActionResult SortImeRastuce(int RacunarId)
        {
            KomponentaKomponente kkvm = new KomponentaKomponente();
            kkvm.Komponenta = new Komponenta();
            kkvm.RacunarId = RacunarId;
            kkvm.Komponenta.RacunarId = RacunarId;
            kkvm.Komponente = KomponentaRepository.SortImeRastuce(RacunarId); ;
            return View("Index", kkvm);
        }
        public IActionResult SortImeOpadajuce(int RacunarId)
        {
            KomponentaKomponente kkvm = new KomponentaKomponente();
            kkvm.Komponenta = new Komponenta();
            kkvm.RacunarId = RacunarId;
            kkvm.Komponenta.RacunarId = RacunarId;
            kkvm.Komponente = KomponentaRepository.SortImeOpadajuce(RacunarId);
            return View("Index", kkvm);
        }
    }
}
