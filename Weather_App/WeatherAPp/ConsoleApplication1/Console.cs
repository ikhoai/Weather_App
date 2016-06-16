using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataCommunication;
using Newtonsoft.Json.Linq;
using WeatherApp.Model.WeatherModel; 


namespace ConsoleApplication1
{
    class ConsoleApp
    {
        static void Main(string[] args)
        {
            WeatherModels model = new WeatherModels(); 

            DataCommunications weather = new DataCommunications();
            string stringData = weather.getDataString(weather.url1);
            JObject jsonData = weather.getJsonFromString(stringData);

            JToken cityInfo = jsonData["city"];
            string cityname = (string) cityInfo["name"]; 
            JToken weatherInfo = jsonData["list"];

            model.cityName = cityname;
            model.FiveDaysInfo = (Array)weatherInfo; 

            JToken dailyWeather;

            foreach (JToken daily in weatherInfo)
            {
                model.cityName = (string)cityInfo;
            }

            Console.WriteLine(model.cityName);
            Console.WriteLine(model.FiveDaysInfo); 

            Console.ReadLine(); 
           
        }
    }
}
