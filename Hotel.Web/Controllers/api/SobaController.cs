using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestaurantReservation.Data.EF;
using RestaurantReservation.Web.Helper.mvc;
using RestaurantReservation.Web.Helper.webapi;
using RestaurantReservation.Web.ViewModels.api;
namespace RestaurantReservation.Web.Controllers
{
    [MyApiAuthorize]
    public class SobaController : MyMvcBaseController
    {
        public SobaController(MyContext db) : base(db)
        {

        }
        [HttpGet]
        public ActionResult<SobaPregledVM> Index()
        {
            var x = HttpContext.GetKorisnikOfAuthToken();
            var model = new SobaPregledVM()
            {
                rows = _db.Soba
                    .OrderByDescending(s => s.Id)
                    .Select(s => new SobaPregledVM.Row
                    {
                        id = s.Id,
                        naziv = s.Naziv,
                        opis = s.Opis,
                        detalji = s.Detalji

                    }).ToList()
            };


            return Json(model);
        }
    }
}