using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataCommunication;
using Newtonsoft.Json.Linq;
using WeatherApp.Model.WeatherModel;

namespace BusinessLogic
{
    public class BusinesLogics

    {
        WeatherModels model = new WeatherModels();

        DataCommunications weather = new DataCommunications();

        public WeatherModels getDataForViewModel(DataCommunications data)
        {
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

            return model; 

        }




    }

