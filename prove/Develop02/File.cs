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

                /*foreach (var entry in entries)
                {                    
                    string data = $"{entry._date}|{entry._prompt}|{entry._response}";
                    outputFile.WriteLine(data);
                }*/
            }
        }

        public List<Entry> LoadFromFile(string fileName){
            List<Entry> entries = new List<Entry>();
            
            var data = System.IO.File.ReadAllText(fileName);
            entries = JsonConvert.DeserializeObject<List<Entry>>(data);
            /*string[] lines = System.IO.File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] parts = line.Split("|");

                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];
                entries.Add(new Entry 
                {
                    _date = date, 
                    _prompt = prompt, 
                    _response = response 
                });
            }*/

            return entries;
        }
    }
}