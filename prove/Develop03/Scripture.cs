using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop03
{
    public class Scripture
    {
        private string _text;
        private readonly Reference _reference;       
        private List<Word> _words;
        private int _count;

        public Scripture(string text, Reference reference){
            _text = text;
            _reference = reference;
            _words = new List<Word>();
            SplitWords();
        }

        public void HideWord(){
            var word = new Word();
            bool isHidden = false;

            do
            {
                Random rnd = new Random();
                int position  = rnd.Next(0, _words.Count);
                word = _words[position];

                if(!word.GetIsHidden()){
                    word.HideWord();
                    isHidden = true;
                }

            } while (isHidden == false);            
        }

        public string GetRenderedText(){
            StringBuilder response = new StringBuilder();
            foreach (var word in _words)
            {
                response.AppendFormat("{0} ", word.GetText());
            } 

            return response.ToString().Trim();
        }

        private void SplitWords(){
            foreach (var item in _text.Split(" "))
            {
                _words.Add(new Word(item));
            }
        }

        public int GetCount(){
            return _words.Where(w => !w.GetIsHidden()).ToList().Count;
        }
        public bool IsAnyWordVisible(){
            var count = _words.Where(w => !w.GetIsHidden()).ToList().Count;

            return count > 0;
        }
    }
}