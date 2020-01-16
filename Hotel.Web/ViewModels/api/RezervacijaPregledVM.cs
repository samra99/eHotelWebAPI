using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReservation.Web.ViewModels.api
{
    public class RezervacijaPregledVM
    {

        public class Row
        {
            public int? id;
            
            public string datumDolaska;
            public string datumOdlaska;
            public string korsnik;

            public int BrojOsoba { get; set; }
            public int BrojDjece { get; set; }
            public int BrojSoba { get; set; }



        }

        public List<Row> rows;
    }
}
