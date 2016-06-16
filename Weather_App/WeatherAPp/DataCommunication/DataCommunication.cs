using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json.Linq;

namespace DataCommunication
{
    public class DataCommunications
    {
        public string url1 = "http://api.openweathermap.org/data/2.5/forecast/daily?id=1581129&appid=82c26c8ca12c896805252d9f1b83ed77";

        public string getDataString(string url)
        {
            string json = new WebClient().DownloadString(url); 
            return json; 
        }

        public JObject getJsonFromString(string json) {
            JObject data = JObject.Parse(json);
            return data; 
        }
       

    }

    //82c26c8ca12c896805252d9f1b83ed77 Token API
    //1581129 City ID
}
