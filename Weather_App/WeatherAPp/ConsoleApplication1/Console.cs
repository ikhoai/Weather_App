using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataCommunication;
using Newtonsoft.Json.Linq; 


namespace ConsoleApplication1
{
    class ConsoleApp
    {
        static void Main(string[] args)
        {
            
            DataCommunications weather = new DataCommunications();
            string stringData = weather.getDataString(weather.url1);
            JObject jsonData = weather.getJsonFromString(stringData);

            Console.WriteLine(jsonData);

            Console.ReadLine(); 
           
        }
    }
}
