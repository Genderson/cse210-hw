
namespace Develop03
{
    public class Reference
    {
        private string _book;
        private int _chapter;
        private int _startVerse;
        private int _endVerse;

        public Reference(string book, int chapter, int startVerse)
        {
            _book = book;
            _chapter = chapter;
            _startVerse = startVerse;
        }
        public Reference(string book, int chapter, int startVerse, int endVerse)
        {
            _book = book;
            _chapter = chapter;
            _startVerse = startVerse;
            _endVerse = endVerse;
        }

        public string DisplayReference()
        {
            string verse = _endVerse > 0 ? $"{_startVerse} - {_endVerse}" : $"{_startVerse}";
            
            return $"{_book} {_chapter}: {verse}";
        }
    }
}