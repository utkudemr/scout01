using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using deneme1.Models.Entitiy;
using deneme1.Models.ViewModel;

namespace deneme1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            FutbolEntity db = new FutbolEntity();
            var sporcular = db.Sporcu.Select(i => new MakaleIcerikViewModel()
            {
                Id = i.Id,
                Ad = i.Ad,
                Soyad = i.Soyad,
                Makale = i.Makale.Select(b => new MakaleViewModel()
                {
                    Baslik = b.Baslik,
                    Icerik = b.Icerik
                }).ToList()
            }).ToList();



            return View(sporcular);


        }

        public ActionResult Insert()
        {
            ViewBag.LeaugeList = new SelectList(GetLigler(), "LiglerId", "Ad");
            return View();
        }
        [HttpPost]
        public ActionResult Insert(SporcuViewModel sporcu) {
            FutbolEntity db = new FutbolEntity();
            Makale icerik = new Makale
            {
                Baslik = sporcu.Baslik,
                Icerik = sporcu.Icerik,
                SporcuId = sporcu.SporcuId
            };
            db.Makale.Add(icerik);
            db.SaveChanges();
            return Json("Success",JsonRequestBehavior.AllowGet);
        }

        public List<Ligler> GetLigler()
        {
            FutbolEntity db = new FutbolEntity();
            List<Ligler> ligler = db.Ligler.ToList();
            return ligler;
        }

        public ActionResult GetTakimlar(int LigId)
        {
            FutbolEntity db = new FutbolEntity();
            List<Takim> takimlar = db.Takim.Where(x=>x.LiglerId==LigId).ToList();
            ViewBag.Takimlar = new SelectList(takimlar, "TakimId", "Ad");
            return PartialView("TakimlarPartialView");
        }
        public ActionResult GetOyuncular(int TakimId)
        {
            FutbolEntity db = new FutbolEntity();
            List<Sporcu> sporcular = db.Sporcu.Where(i => i.TakımId == TakimId).ToList();
            ViewBag.Oyuncular = new SelectList(sporcular, "Id", "Ad");
            return PartialView("OyuncularPartialView");
            
        }
        public JsonResult GetBilgiler(int OyuncuId) {
            FutbolEntity db = new FutbolEntity();
            SporcuViewModel sporcular = new SporcuViewModel();
            //  var bilgiler = db.Sporcu.FirstOrDefault(i => i.Id == OyuncuId);
            Sporcu bilgiler = db.Sporcu.FirstOrDefault(a => a.Id == OyuncuId);
            sporcular.Ad = bilgiler.Ad;
            sporcular.Soyad = bilgiler.Soyad;
            sporcular.Id = bilgiler.Id;
            sporcular.Dtarihi = (bilgiler.Dtarihi);
            return Json(sporcular,JsonRequestBehavior.AllowGet);
        }
        public ActionResult off() {
            return View();
        }

    }
}