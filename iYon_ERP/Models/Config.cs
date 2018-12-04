using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iYon_ERP.Models
{
    public class Config
    {
        [JsonProperty("Id")]
        public int Id { get; private set; }
        [JsonProperty("Efficience")]
        public double Efficience { get; private set; }
    }
}
