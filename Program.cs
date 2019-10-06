using System;
using System.Collections.Generic;

namespace PlanetChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use the list of planets you created in the previous chapter or create a new one with all eight planets.
            List<string> planetList = new List<string>(){
                "Mercury",
                "Venus",
                "Earth",
                "Mars",
                "Jupiter",
                "Saturn",
                "Neptune",
                "Uranus"
            };

            // Create a list containing KeyValuePairs. Each KeyValuePair will hold the name of a spacecraft that we have launched, and the name of a planet that it has visited. The key of the KeyValuePair will be the probe name, and the value will be the planet it visited.

            List<KeyValuePair<string, string>> probeDestinations = new List<KeyValuePair<string, string>>();

            // Add some planet/probe combinations to the list
            probeDestinations.Add(new KeyValuePair<string, string>("Viking 1", "Mars"));
            probeDestinations.Add(new KeyValuePair<string, string>("Mariner 1", "Venus"));
            probeDestinations.Add(new KeyValuePair<string, string>("Voyager 1", "Jupiter"));
            probeDestinations.Add(new KeyValuePair<string, string>("Voyager 1", "Saturn"));

            // Iterate over planetList, and inside that loop, iterate over the list of key-value pairs. Write to the console, for each planet, which probes have visited it.

            foreach (string planet in planetList)
            {
                Console.WriteLine(planet);
            }

            // // Iterate planets
            // foreach (string planet in planetList)
            // {
            //     // List to store probes that visited the planet
            //     List<string> matchingProbes = new List<string>();

            //     // Iterate probeDestinations
            //     foreach ()
            //     {
            //             Does the current probe's destination
            //             match the value of the `planet` variable?
            //             If so, add it to the list.
            //     }

            //         Use String.Join(",", matchingProbes) as part of the
            //         solution to get the output below. It's the C# way of
            //         writing `array.join(",")` in JavaScript.
            //     Console.WriteLine($"{}: {}");
            // }



        }
    }
}
