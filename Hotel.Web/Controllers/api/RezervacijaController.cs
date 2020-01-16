using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantReservation.Data.EF;
using RestaurantReservation.Data.EntityModels;
using RestaurantReservation.Web.Helper.mvc;
using RestaurantReservation.Web.Helper.webapi;
using RestaurantReservation.Web.ViewModels.api;

namespace RestaurantReservation.Web.Controllers.api
{
    [MyApiAuthorize]
    public class RezervacijaController : MyWebApiBaseController
    {
        public RezervacijaController(MyContext db) : base(db)
        {

        }

        [HttpGet]
        public ActionResult<RezervacijaPregledVM> Get()
        {
            var korisnik = HttpContext.GetKorisnikOfAuthToken();
            var model = new RezervacijaPregledVM()
            {
                rows = _db.Rezervacija.Where(x=>x.KorisnikId == korisnik.Id)
                    .OrderByDescending(s => s.Id)
                    .Select(s => new RezervacijaPregledVM.Row
                    {
                        id = s.Id,
                        BrojDjece = s.BrojDjece,
                        BrojOsoba = s.BrojOsoba,
                        BrojSoba = s.BrojSoba,
                        datumDolaska = s.DatumDolaska.ToString(),
                        datumOdlaska = s.DatumOdlaska.ToString()

                    }).ToList()
            };


            return Json(model);
        }

        [HttpPost]
        public ActionResult<RezervacijaPregledVM> Post([FromBody] RezervacijaAddVM input)
        {
            var korisnik = HttpContext.GetKorisnikOfAuthToken();

            Rezervacija rezervacija = new Rezervacija()
            {

                BrojDjece = input.BrojDjece,
                BrojOsoba = input.BrojOsoba,
                BrojSoba = input.BrojSoba,
                DatumDolaska =DateTime.Parse( input.datumDolaska.Replace('.','-')),
                DatumOdlaska = DateTime.Parse(input.datumOdlaska.Replace('.', '-')),
                KorisnikId = korisnik.Id
            };

            _db.Rezervacija.Add(rezervacija);
            _db.SaveChanges();
            return Json(rezervacija);
        }


        [HttpPost]
        public ActionResult<RezervacijaPregledVM> Delete([FromBody] RezervacijaDeleteVM input)
        {
            var korisnik = HttpContext.GetKorisnikOfAuthToken();

            Rezervacija r = _db.Rezervacija.Find(input.Id);
            if (r!=null)
            {
            _db.Rezervacija.Remove(r);
            _db.SaveChanges();
            }
            else {
            return Json(input);
            }
            input.Id = 0;
            return Json(input);
        }
    }
}