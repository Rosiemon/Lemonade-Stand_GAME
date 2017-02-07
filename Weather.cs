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
        public string actualTemperture;
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
            Random random = new Random();
            List<string> overcastList = new List<string> { "Cloudy", "Partly Coudy", "Sunny", "Humid", "Rainy", "Stormy"};
            overcast = overcastList[random.Next(0, 5)];
        }
        public void DisplayForcast()
        {
            RandomizeOvercast();
            RandomizeForcast();
            Console.BackgroundColor = ConsoleColor.Yellow; Console.WriteLine($"\nTODAYS'S FORCAST: {temperatureForcast} degrees and {overcast}"); Console.ResetColor();

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
        }
        public void RandomizeWeather()
        {
            RandomizeForcast();
            switch (overcast)
            {
                case "Cloudy":
                    Random randomCloudy = new Random();
                    List<string> cloudyList = new List<string> {"Cloudy", "Partly Coudy", "Sunny"};
                    overcast = cloudyList[randomCloudy.Next(0, 2)];
                    break;
                case "Partly Cloudy":
                    Random randomPartlyCloudy = new Random();
                    List<string> partlyCloudyList = new List<string> { "Cloudy", "Partly Coudy", "Sunny"};
                    overcast = partlyCloudyList[randomPartlyCloudy.Next(0, 2)];
                    break;
                case "Sunny":
                    Random randomSunny = new Random();
                    List<string> sunnyList = new List<string> {"Partly Coudy", "Sunny", "Humid"};
                    overcast = sunnyList[randomSunny.Next(0, 2)];
                    break;
                case "Humid":
                    Random randomHumid = new Random();
                    List<string> humidList = new List<string> {"Sunny", "Humid"};
                    overcast = humidList[randomHumid.Next(0, 1)];
                    break;
                case "Rainy":
                    Random random = new Random();
                    List<string> overcastList = new List<string> {"Cloudy", "Rainy", "Stormy" };
                    overcast = overcastList[random.Next(0, 2)];
                    break;
                case "Stormy":
                    Random randomStormy = new Random();
                    List<string> stormyList = new List<string> {"Rainy", "Stormy" };
                    overcast = stormyList[randomStormy.Next(0, 1)];
                    break;
            }
        }
    }
}