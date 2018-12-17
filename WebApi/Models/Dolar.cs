using System.Threading.Tasks;
using WebApi.Helpers;

namespace WebApi.Models
{
    public class Dolar : ICotizacion
    {

        public string Moneda { get; set; }
        public decimal Precio { get; set; }


        public Dolar()
        {
            Moneda = "dolar";
            Precio = ExtraerCotizacion();
        }

        public decimal ExtraerCotizacion()
        {
            string URL = "https://api.cambio.today/v1/quotes/USD/ARS/json?quantity=1&key=1526|Qb_bkscLP68GfGgjTmMNM09OR_vwi9VF";
            string urlParameters = "?key=1526|Qb_bkscLP68GfGgjTmMNM09OR_vwi9VF";

            HttpClientHelper client = new HttpClientHelper(URL, urlParameters);
            return client.GetPrecio();
        }
    }
}
