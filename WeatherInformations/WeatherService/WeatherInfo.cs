using System.Net;
using System.Reflection;
using Newtonsoft.Json;

namespace WeatherService
{
    public class WeatherInfo
    {
        public string GetInfo(string inputCity)
        {
            var filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),"in.json");
            var file = File.ReadAllText(filePath);
            var citiesData = JsonConvert.DeserializeObject<List<CitiesModel>>(file);
            
            var cityData = citiesData?.Where(x=> x.City.ToLower() == inputCity.ToLower()).FirstOrDefault();

            if(cityData != null)
            {
                var url = string.Format(@"https://api.open-meteo.com/v1/forecast?latitude={0}&longitude={1}&current_weather=true",cityData.Lat,cityData.Lng);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    var res = reader.ReadToEnd();
                    return res;
                }
            }
            return "CITY_NOT_FOUND";
        }
    }
}