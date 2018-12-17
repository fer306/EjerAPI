using System.Threading.Tasks;
using WebApi.Helpers;

namespace WebApi.Models
{
    public interface ICotizador
    {
       
        string Moneda { get; set; }
        decimal Precio { get; set; }
        decimal ExtraerCotizacion();


    }
}