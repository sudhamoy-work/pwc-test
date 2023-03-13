using Newtonsoft.Json;

namespace WeatherService
{
    public class Program 
    {
        public static void Main(String[] args)
        {
            try
            {
                var inputCity = string.Empty;

                if(args.Count()>0)
                {
                    inputCity = args[0].Trim();
                }

                if(string.IsNullOrWhiteSpace(inputCity))
                {
                    System.Console.WriteLine("You haven't entered a city. Please try again.");
                    return;
                }
                
                System.Console.WriteLine("Please Wait...");

                var weatherInfo = new WeatherInfo();
                var res = weatherInfo.GetInfo(inputCity);

                if(res == "CITY_NOT_FOUND")
                {
                    System.Console.WriteLine("Unable to find the entered city. Please try a with different city name.");
                }
                else
                {
                    dynamic parsedJson = JsonConvert.DeserializeObject(res);
                    var result = JsonConvert.SerializeObject(parsedJson?.current_weather, Formatting.Indented);
                    System.Console.WriteLine("The weather informations for {0} is :-",inputCity);
                    System.Console.WriteLine(result);
                }
            }
            catch(Exception ex)
            {
                System.Console.WriteLine(ex.StackTrace);
            }
        }
    }
}