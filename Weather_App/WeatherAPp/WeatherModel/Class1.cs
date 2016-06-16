using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Model.WeatherModel
{
    public class WeatherModels
    {
        public string cityName { get; set; }
        public string temperature { get; set; }
        public DateTime day { get; set;  }
        public Array FiveDaysInfo { get; set; }
    }
}
