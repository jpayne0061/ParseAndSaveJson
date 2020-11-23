using Newtonsoft.Json;
using ParseAndSaveJson.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace ParseAndSaveJson
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathToJson  = @"C:\Users\Evan\source\repos\ParseAndSaveJson\ParseAndSaveJson\data.json";

            string json = File.ReadAllText(pathToJson);

            List<Location> locations = JsonConvert.DeserializeObject<List<Location>>(json);

            SaveObjects(locations);
        }


        static void SaveObjects(List<Location> locationsToSave)
        {
            foreach (Location location in locationsToSave)
            {
                foreach (Bundle bundle in location.Bundles)
                {
                    foreach (Item item in bundle.Items)
                    {
                        SaveItem(item);
                    }

                    SaveBundle(bundle);
                }

                SaveLocation(location);
            }
        }

        static void SaveLocation(Location location)
        {
            //need to implement saving to database
        }

        static void SaveBundle(Bundle bundle)
        {
            //need to implement saving to database
        }

        static void SaveItem(Item item)
        {
            //need to implement saving to database
        }

    }
}
