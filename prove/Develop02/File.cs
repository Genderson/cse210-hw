using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Develop02
{
    public class File
    {
        public void SaveToFile(string fileName){
            
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                // You can add text to the file with the WriteLine method
                outputFile.WriteLine("This will be the first line in the file.");
                
                // You can use the $ and include variables just like with Console.WriteLine
                string color = "Blue";
                outputFile.WriteLine($"My favorite color is {color}");
            }
        }

        public void LoadFromFile(string fileName){
            
        }
    }
}