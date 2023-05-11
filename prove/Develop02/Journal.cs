using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop02
{
    public class Journal
    {
        private List<Entry> _entries = new List<Entry>();
     
        private readonly File _file;
        private readonly PromptGenerator _promptGenerator;

        public Journal(){
            _file = new File();
            _promptGenerator = new PromptGenerator();
        }

        public string GetPrompt(){
            return _promptGenerator.GetPrompt();
        }

        public void WriteNewEntry(string prompt, string response){
            _entries.Add(new Entry {
                _response = response,
                _prompt = prompt,
                _date = DateTime.Now.ToShortDateString()
            });
        }

        public void SaveToFile(string fileName){

            _file.SaveToFile(fileName, _entries);
        }

        public void LoadFromFile(string fileName){
            _entries = _file.LoadFromFile(fileName);
        }

        public string DisplayJournal(){
            string journalEntries = string.Empty;

            foreach (var entry in _entries)
            {
                journalEntries += entry.Display() + "\r\n";
            }

            return journalEntries;
        }
    }
}