﻿using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RestaurantReservation.Data.EF;
using RestaurantReservation.Data.EntityModels;
using RestaurantReservation.Web.Helper;
using RestaurantReservation.Web.Helper.mvc;
using RestaurantReservation.Web.ViewModels;

namespace RestaurantReservation.Web.Controllers
{
    [MyMvcAuthorize()]
    public class SesijaController : MyMvcBaseController
    {

        public SesijaController(MyContext db):base(db)
        {
        }

        public IActionResult Index()
        {
            var kId = HttpContext.GetLogiraniKorisnik().Id;
            SesijaIndexVM model = new SesijaIndexVM();
            model.Rows = _db.AutorizacijskiToken
                .Where(x=>x.KorisnickiNalogId == kId)
                .Select(s => new SesijaIndexVM.Row
            {
                VrijemeLogiranja = s.VrijemeEvidentiranja,
                token = s.Vrijednost,
                IpAdresa = s.IpAdresa,
                deviceInfo = s.DeviceInfo
            }).ToList();
            model.TrenutniToken = HttpContext.GetTrenutniToken();
            return View(model);
        }

        public IActionResult Obrisi(string token)
        {
            AutorizacijskiToken obrisati =_db.AutorizacijskiToken.FirstOrDefault(x => x.Vrijednost == token);
            if (obrisati != null)
            {
                _db.AutorizacijskiToken.Remove(obrisati);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}