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
        private string _urlParameters = "";
        HttpClient _client = new HttpClient();


        public HttpClientHelper( string url, string urlParameters )
        {
            _url = url;
            _urlParameters = urlParameters;
        }

        public decimal GetPrecio()
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

