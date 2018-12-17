using Newtonsoft.Json;
using System;

namespace WebApi.Helpers
{
    public class Result
    {
        [JsonProperty("result")]
        public CotizacionMoneda CotizacionMoneda { get; set; }

    }
}
