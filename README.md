# Weather Information

This is a Command Line tool in Dotnet which will take user input as City and gives the weather related information e.g. Temperature , Windspeed etc.

**Note:** Latitude, longitude data for the cities is downloaded from [`https://simplemaps.com/data/in-cities`](https://simplemaps.com/data/in-cities) and stored as a JSON file `in.json`.

## Restore, test and run

Please navigate to the *WeatherInformations* directory and type the following commands:

```
dotnet restore
```
`dotnet restore` restores the packages of both projects.

```
dotnet test
```
`dotnet test` builds both projects and runs all of the configured tests.

```
dotnet run --project ./WeatherService <city>  
```
`dotnet run --project ./WeatherService <city>` builds and run the Command Line tool and show the output in Command Line. Please replace `<city>` with the city name you wish to see the data.


Few sample run commands are mentioned below which is going to fetch the data for `Delhi` and `Kolkāta` respectively.

```
dotnet run --project ./WeatherService "Delhi" 
```
```
dotnet run --project ./WeatherService "Kolkāta" 
```
