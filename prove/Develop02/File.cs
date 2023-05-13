using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
namespace Develop02
{
    public class File
    {
        public void SaveToFile(string fileName, List<Entry> entries){
            
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                var jsonEntries = JsonConvert.SerializeObject(entries);
                outputFile.WriteLine(jsonEntries);
            }
        }

        public List<Entry> LoadFromFile(string fileName){
            List<Entry> entries = new List<Entry>();
            
            var data = System.IO.File.ReadAllText(fileName);
            entries = JsonConvert.DeserializeObject<List<Entry>>(data);

            return entries;
        }
    }
}