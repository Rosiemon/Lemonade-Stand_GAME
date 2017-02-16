using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        public string overcast;
        public int temperatureForcast;
        public string actualOvercast;
        public int actualTemperature;
        public int minCloudy;
        public int maxCloudy;
        public int minPartlyCloudy;
        public int maxPartlyCloudy;
        public int minSunny;
        public int maxSunny;
        public int minHumid;
        public int maxHumid;
        public int minRainy;
        public int maxRainy;
        public int minStormy;
        public int maxStormy;
        public void RandomizeOvercast()
        {
            if (overcast == null)
            {
                Random random = new Random();
                List<string> overcastList = new List<string> { "Cloudy", "Partly Cloudy", "Sunny", "Humid", "Rainy", "Stormy" };
                overcast = overcastList[random.Next(0, 5)];
                RandomizeForcast();
            }
            else
            {
                DisplayForcast();
            }
            
        }
        public void DisplayForcast()
        {
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine($"\nTODAYS'S FORCAST: {temperatureForcast} degrees and {overcast}"); Console.ResetColor();

        }
        public void RandomizeForcast()
        {
            switch(overcast)
            {
                case "Cloudy":
                    minCloudy = 50;
                    maxCloudy = 65;
                    Random cloudy = new Random();
                    temperatureForcast = cloudy.Next(minCloudy, maxCloudy);
                    break;
                case "Partly Cloudy":
                    minPartlyCloudy = 64;
                    maxPartlyCloudy = 76;
                    Random partlyCloudy = new Random();
                    temperatureForcast = partlyCloudy.Next(minPartlyCloudy, maxPartlyCloudy);
                    break;
                case "Sunny":
                    minSunny = 68;
                    maxSunny = 84;
                    Random sunny = new Random();
                    temperatureForcast = sunny.Next(minSunny, maxSunny);
                    break;
                case "Humid":
                    minHumid = 80;
                    maxHumid = 100;
                    Random humid = new Random();
                    temperatureForcast = humid.Next(minHumid, maxHumid);
                    break;
                case "Rainy":
                    minRainy = 38;
                    maxRainy = 52;
                    Random rainy = new Random();
                    temperatureForcast = rainy.Next(minRainy, maxRainy);
                    break;
                case "Stormy":
                    minStormy = 30;
                    maxStormy = 45;
                    Random stormy = new Random();
                    temperatureForcast = stormy.Next(minStormy, maxStormy);
                    break;
            }
            DisplayForcast();
        }
        public void DisplayWeather()
        {
            RandomizeWeather();
            SetWeather();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine($"\nThe actual weather for today is {actualTemperature} degrees and {actualOvercast} \n"); Console.ResetColor();
        }
        public void RandomizeWeather()
        {
            if (overcast == null)
            {
                RandomizeOvercast();
                RandomizeForcast();
                RandomizeWeather();
                SetWeather();
            }
            else
            {
                switch (overcast)
                {
                    case "Cloudy":
                        Random randomCloudy = new Random();
                        List<string> cloudyList = new List<string> { "Cloudy", "Partly Cloudy", "Sunny" };
                        actualOvercast = cloudyList[randomCloudy.Next(0, 2)];
                        break;
                    case "Partly Cloudy":
                        Random randomPartlyCloudy = new Random();
                        List<string> partlyCloudyList = new List<string> { "Cloudy", "Partly Cloudy", "Sunny" };
                        actualOvercast = partlyCloudyList[randomPartlyCloudy.Next(0, 2)];
                        break;
                    case "Sunny":
                        Random randomSunny = new Random();
                        List<string> sunnyList = new List<string> { "Partly Cloudy", "Sunny", "Humid" };
                        actualOvercast = sunnyList[randomSunny.Next(0, 2)];
                        break;
                    case "Humid":
                        Random randomHumid = new Random();
                        List<string> humidList = new List<string> { "Sunny", "Humid" };
                        actualOvercast = humidList[randomHumid.Next(0, 1)];
                        break;
                    case "Rainy":
                        Random random = new Random();
                        List<string> rainyList = new List<string> { "Cloudy", "Rainy", "Stormy" };
                        actualOvercast = rainyList[random.Next(0, 2)];
                        break;
                    case "Stormy":
                        Random randomStormy = new Random();
                        List<string> stormyList = new List<string> { "Rainy", "Stormy" };
                        actualOvercast = stormyList[randomStormy.Next(0, 1)];
                        break;
                }
            }
        }
        public void SetWeather()
        {
            switch (actualOvercast)
            {
                case "Cloudy":
                    minCloudy = 50;
                    maxCloudy = 65;
                    Random cloudy = new Random();
                    actualTemperature = cloudy.Next(minCloudy, maxCloudy);
                    break;
                case "Partly Cloudy":
                    minPartlyCloudy = 64;
                    maxPartlyCloudy = 76;
                    Random partlyCloudy = new Random();
                    actualTemperature = partlyCloudy.Next(minPartlyCloudy, maxPartlyCloudy);
                    break;
                case "Sunny":
                    minSunny = 68;
                    maxSunny = 84;
                    Random sunny = new Random();
                    actualTemperature = sunny.Next(minSunny, maxSunny);
                    break;
                case "Humid":
                    minHumid = 80;
                    maxHumid = 100;
                    Random humid = new Random();
                    actualTemperature = humid.Next(minHumid, maxHumid);
                    break;
                case "Rainy":
                    minRainy = 38;
                    maxRainy = 52;
                    Random rainy = new Random();
                    actualTemperature = rainy.Next(minRainy, maxRainy);
                    break;
                case "Stormy":
                    minStormy = 30;
                    maxStormy = 45;
                    Random stormy = new Random();
                    actualTemperature = stormy.Next(minStormy, maxStormy);
                    break;
            }
        }
        public void ResetWeather()
        {
            actualTemperature = 0;
        }
    }
}