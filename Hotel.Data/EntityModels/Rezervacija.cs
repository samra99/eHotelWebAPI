using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RestaurantReservation.Data.EntityModels
{
   public  class Rezervacija
    {
        public int Id { get; set; }
        
        public DateTime DatumDolaska { get; set; }
        public DateTime DatumOdlaska { get; set; }
        public int BrojOsoba { get; set; }
        public int BrojDjece { get; set; }
        public int BrojSoba { get; set; }

      
        [ForeignKey(nameof(Korisnik))]
        public int? KorisnikId { get; set; }
        public Korisnik Korisnik { get; set; }

       
    }
}
