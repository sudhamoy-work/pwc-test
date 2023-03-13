using Newtonsoft.Json;

namespace WeatherService
{
    public class CitiesModel
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("lat")]
        public string Lat { get; set; }

        [JsonProperty("lng")]
        public string Lng { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("iso2")]
        public string Iso2 { get; set; }

        [JsonProperty("admin_name")]
        public string AdminName { get; set; }

        [JsonProperty("capital")]
        public string Capital { get; set; }

        [JsonProperty("population")]
        public string Population { get; set; }

        [JsonProperty("population_proper")]
        public string PopulationProper { get; set; }
    }

    public class CurrentWeather
    {
        [JsonProperty("temperature")]
        public double Temperature { get; set; }

        [JsonProperty("windspeed")]
        public double Windspeed { get; set; }

        [JsonProperty("winddirection")]
        public double Winddirection { get; set; }

        [JsonProperty("weathercode")]
        public int Weathercode { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }
    }

    public class WeatherModel
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("generationtime_ms")]
        public double GenerationtimeMs { get; set; }

        [JsonProperty("utc_offset_seconds")]
        public int UtcOffsetSeconds { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("timezone_abbreviation")]
        public string TimezoneAbbreviation { get; set; }

        [JsonProperty("elevation")]
        public double Elevation { get; set; }

        [JsonProperty("current_weather")]
        public CurrentWeather CurrentWeather { get; set; }
    }
}