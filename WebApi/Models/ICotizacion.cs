using System.Threading.Tasks;
using WebApi.Helpers;

namespace WebApi.Models
{
    public interface ICotizacion
    {
       
        string Moneda { get; set; }
        decimal Precio { get; set; }
        decimal ExtraerCotizacion();


    }
}