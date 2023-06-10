using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
namespace Develop04
{
    public class File
    {
        public void SaveToFile(string fileName, List<ActivityInformation> entries)
        {            
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                var jsonEntries = JsonConvert.SerializeObject(entries);
                outputFile.WriteLine(jsonEntries);
            }
        }

        public List<ActivityInformation> LoadFromFile(string fileName)
        {
            List<ActivityInformation> entries = new List<ActivityInformation>();
            
            if(System.IO.File.Exists(fileName))
            {
                var data = System.IO.File.ReadAllText(fileName);
                entries = JsonConvert.DeserializeObject<List<ActivityInformation>>(data);
            }        

            return entries;
        }
    }
}