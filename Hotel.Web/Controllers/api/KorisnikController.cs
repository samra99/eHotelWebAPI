using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantReservation.Data.EF;
using RestaurantReservation.Data.EntityModels;
using RestaurantReservation.Web.Helper.webapi;
using RestaurantReservation.Web.ViewModels.api;

namespace RestaurantReservation.Web.Controllers.api
{
    public class KorisnikController : MyWebApiBaseController
    {
        public KorisnikController(MyContext db) : base(db)
        {

        }

        [HttpPost]
        public ActionResult<AutentifikacijaResultVM> Post([FromBody] KorisnikAddVM input)
        {
            var korisnik = HttpContext.GetKorisnikOfAuthToken();

            Korisnik korisnikNew = new Korisnik()
            {
                Ime = input.ime,
                Prezime = input.prezime,
                BrojPasosa = input.pasos,
                Mail = input.email,
                KorisnickiNalog =  new KorisnickiNalog()
                {
                    KorisnickoIme = input.username,
                    Lozinka = input.password
                }

            };

            _db.Korisnik.Add(korisnikNew);
            _db.SaveChanges();
           
            string token = Guid.NewGuid().ToString();

            AutentifikacijaResultVM model = _db.Korisnik
                .Where(w => w.KorisnickiNalog.KorisnickoIme == korisnikNew.KorisnickiNalog.KorisnickoIme && w.KorisnickiNalog.Lozinka == korisnikNew.KorisnickiNalog.Lozinka)
                .Select(s => new AutentifikacijaResultVM
                {
                    ime = s.Ime,
                    korisnickiNalogId = s.KorisnickiNalogId,
                    mail = s.Mail,
                    prezime = s.Prezime,
                    username = s.KorisnickiNalog.KorisnickoIme,
                    token = token,
                }).SingleOrDefault();


            if (model != null)
            {
                _db.AutorizacijskiToken.Add(new AutorizacijskiToken
                {
                    Vrijednost = model.token,
                    KorisnickiNalogId = model.korisnickiNalogId.Value,
                    VrijemeEvidentiranja = DateTime.Now,
                    DeviceInfo = "Mobile app - ",
                    IpAdresa = HttpContext.Connection.RemoteIpAddress + ":" + HttpContext.Connection.RemotePort
                });
                _db.SaveChanges();
            }

            return model;
        }
    }
}