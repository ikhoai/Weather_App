using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataCommunication;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json; 
using WeatherApp.Model.WeatherModel; 


namespace ConsoleApplication1
{
    class ConsoleApp
    {
        static void Main(string[] args)
        {
            WeatherModels model = new WeatherModels(); 

            DataCommunications weather = new DataCommunications();
            string stringData = weather.getDataString(weather.url());
            JObject jsonData = weather.getJsonFromString(stringData);

            // Testing 2: 
            IList<JToken> results = jsonData["list"].Children().ToList();

            model.cityName = jsonData["city"]["name"].ToString();

            Console.WriteLine(model.cityName); 

            foreach (var result in results)
            {
                model.temp = result["main"]["temp"].ToString(); 
                Console.WriteLine(model.temp);       
            }

            // ===============
            JToken cityInfo = jsonData["city"];
            string cityname = (string) cityInfo["name"]; 
            JToken weatherInfo = jsonData["list"];

            model.cityName = cityname;
            


            model = JsonConvert.DeserializeObject <WeatherModels> (stringData); 


            Console.WriteLine(results);

            Console.ReadLine(); 
           
        }
    }
}
