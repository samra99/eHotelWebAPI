﻿using System.ComponentModel.DataAnnotations;
using RestaurantReservation.Web.Helper;

namespace RestaurantReservation.Web.ViewModels.api
{
    public class AutentifikacijaLoginPostVM
    {
        public string Username { get; set; }
        public string Password{ get; set; }
        public string deviceInfo{ get; set; }
    }
}
