namespace WeatherService.Tests;

public class WeatherInfoFacts
{
    private readonly WeatherInfo _weatherInfo;
    public WeatherInfoFacts()
    {
        _weatherInfo = new WeatherInfo();
    }

    [Fact]
    public void Should_return_weather_data_when_correct_city_is_provided()
    {
        var result = _weatherInfo.GetInfo("Delhi");
        Assert.Contains("temperature", result);
    }

    [Fact]
    public void Should_return_not_found_if_incorrect_city_is_provided()
    {
        var result = _weatherInfo.GetInfo("986caea6-54f8-44de-9e57-ed9e78557d59");
        Assert.Contains("CITY_NOT_FOUND", result);
    }
}