using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RestAPI.Models {
    [DataContract]
    public class WeatherInfo {
        [DataMember(Name ="location")]
        public string Location { get; set; }
        [DataMember(Name = "Degree")]
        public float Degree { get; set; }
        [DataMember(Name = "DateTime")]
        public DateTime DateTime { get; set; }
    }
}