using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace WebApi.Helpers
{
    public class HttpClientHelper
    {
        private string _url = "";
        private string _urlParameters = "?key=1526|Qb_bkscLP68GfGgjTmMNM09OR_vwi9VF";
        HttpClient _client = new HttpClient();


        public HttpClientHelper( string url )
        {
            _url = url;
        }

        public decimal getCotizacion()
        {
            _client.BaseAddress = new Uri(_url);
            _client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response =  _client.GetAsync(_urlParameters).Result;

            if (response.IsSuccessStatusCode)
            {
                string respuesta = response.Content.ReadAsStringAsync().Result;
                Result dataObjet = JsonConvert.DeserializeObject<Result>(respuesta);


                return dataObjet.CotizacionMoneda.value;
            }

            return 0;

        }
    }
}

