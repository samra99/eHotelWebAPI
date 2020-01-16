using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RestaurantReservation.Web.Controllers
{
    public class NoviController : Controller
    {
        public IActionResult Index()
        {
            string novi = "novi";
            return Json(novi);
        }
    }
}