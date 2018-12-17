using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CotizacionController : ControllerBase
    {
        //private readonly ContextoCotizacion _context;

        public CotizacionController( )
        {
            //_context = context;

            //if (_context.Cotizaciones.Count() == 0)
            //{
            //    _context.Cotizaciones.AddRange(new List<Cotizacion>() {
            //        new Cotizacion { Moneda = "dolar", Precio = 38.2m } ,
            //        new Cotizacion { Moneda = "euro", Precio = 43.14m } ,
            //        new Cotizacion { Moneda = "real", Precio = 9.74m } ,

            //    });                    
            //    _context.SaveChanges();
            //}

        }

        // GET: api/Cotizacion
        [HttpGet]
        public IEnumerable<ICotizador> GetCotizaciones()
        {
            //var a = new Cotizacion();
            //a.test();
            return null;
        }


        // GET: api/Cotizacion/dolar
        [HttpGet("{Moneda}")]
        public IActionResult GetCotizacionByMoneda( [FromRoute] string Moneda )
        {
            ICotizador cotizacion  = null;

            if (Moneda == "dolar")
            {
                 cotizacion = new DolarCotizacion();
            }
            else if (Moneda == "euro")
            {
                cotizacion = new EuroCotizacion();
            }
            else if (Moneda == "real")
            {
                 cotizacion = new RealCotizacion();
            }



            if (cotizacion == null)
            {
                return NotFound();
            }

            return Ok(cotizacion);

        }
    }
    }