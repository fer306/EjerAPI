using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Helpers
{
    public class CotizacionMoneda
    {
        [JsonProperty("updated")]
        public DateTime updated { get; set; }

        [JsonProperty("source")]
        public string source { get; set; }

        [JsonProperty("target")]
        public string target { get; set; }

        [JsonProperty("value")]
        public decimal value { get; set; }

        [JsonProperty("quantity")]
        public decimal quantity { get; set; }

        [JsonProperty("amount")]
        public decimal amount { get; set; }
    }
}
