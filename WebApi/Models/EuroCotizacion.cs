﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Helpers;

namespace WebApi.Models
{
    public class EuroCotizacion : ICotizador
    {
        public string Moneda { get; set; }
        public decimal Precio { get; set; }

        public EuroCotizacion ()
        {
            Moneda = "euro";
            Precio = ExtraerCotizacion();
        }

        public decimal ExtraerCotizacion()
        {
            string URL = "https://api.cambio.today/v1/quotes/EUR/ARS/json?quantity=1&key=1526|Qb_bkscLP68GfGgjTmMNM09OR_vwi9VF";
            string urlParameters = "?key=1526|Qb_bkscLP68GfGgjTmMNM09OR_vwi9VF";

            HttpClientHelper client = new HttpClientHelper(URL, urlParameters);
            return client.GetPrecio();
        }
    }
}
