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

            List<KeyValuePair<string, string>> probeDestinations = new List<KeyValuePair<string, string>>(){
                new KeyValuePair<string, string>("Viking 1", "Mars"),
                new KeyValuePair<string, string>("Mariner 1", "Venus"),
                new KeyValuePair<string, string>("Voyager 1", "Jupiter"),
                new KeyValuePair<string, string>("Voyager 1", "Saturn"),
                new KeyValuePair<string, string>("Viking 2", "Mars"),
                new KeyValuePair<string, string>("Viking 2", "Neptune"),
                new KeyValuePair<string, string>("Viking 2", "Venus")
            };

            // Iterate over planetList, and inside that loop, iterate over the list of key-value pairs. Write to the console, for each planet, which probes have visited it.

            foreach (string planet in planetList)
            {
                // List to store probes that visited the planet
                List<string> matchingProbes = new List<string>();

                // Iterate probe destinations and add the probe to the planet's matching probes if the value matches the current planet
                foreach(KeyValuePair<string, string> kvp in probeDestinations)
                {
                    if (kvp.Value == planet)
                    {
                        matchingProbes.Add(kvp.Key);
                    }
                }

                // Print the planet and the joined list of probes that have been to that planet
                Console.WriteLine($"{planet}: {String.Join(", ", matchingProbes)}");
            }

        }
    }
}
