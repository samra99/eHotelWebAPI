﻿using System;
using System.Collections.Generic;

namespace RestaurantReservation.Web.ViewModels
{
    public class SesijaIndexVM
    {
        public List<Row> Rows { get; set; }
        public string TrenutniToken { get; set; }

        public class Row
        {
            public DateTime VrijemeLogiranja { get; set; }
            public string token { get; set; }
            public string IpAdresa { get; set; }
            public string deviceInfo { get; set; }
        }
    }
}
