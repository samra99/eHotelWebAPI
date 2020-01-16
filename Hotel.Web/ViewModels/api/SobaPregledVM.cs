﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReservation.Web.ViewModels.api
{
    public class SobaPregledVM
    {
        public List<Row> rows;

        public class Row
        {
            public int? id;
            public string naziv;
            public string opis;
            public string detalji;
           
        }
    }
}
