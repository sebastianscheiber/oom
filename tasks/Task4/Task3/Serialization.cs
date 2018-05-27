using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace Task4
{
    class Serialization
    {
        public static void Execute(IAsset[] assets)
        {

            var format = new JsonSerializerSettings() { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.Auto };
            Console.WriteLine(JsonConvert.SerializeObject(assets, format));

            var input = JsonConvert.SerializeObject(assets, format);
            var profile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            var path = Path.Combine(profile, "output.json");
            File.WriteAllText(path, input);

            
            var inputFromPath = File.ReadAllText(path);
            var fromFile = JsonConvert.DeserializeObject<IAsset[]>(inputFromPath, format);
            foreach (var x in fromFile) Console.WriteLine($"{x.Name} {x.PrintRestValue}");
          
        }


    }
}
