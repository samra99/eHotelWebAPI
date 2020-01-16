﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RestaurantReservation.Data.EntityModels
{
    public class Korisnik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Mail { get; set; }
        public string BrojPasosa { get; set; }

        [ForeignKey(nameof(KorisnickiNalog))]
        public int? KorisnickiNalogId { get; set; }
        public KorisnickiNalog KorisnickiNalog { get; set; }
    }
}
