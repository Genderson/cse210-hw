
namespace Develop03
{
    public class Word
    {
        private string _text;
        private bool _isHidden;

        public Word(){}
        public Word(string text){
            _text = text;
            _isHidden = false;
        }

        public string GetText() => _text;
        public bool GetIsHidden() => _isHidden;
        public void HideWord(){
            int count = _text.Count();
            string hideText = string.Empty;

            for (int i = 0; i < count; i++)
            {
                hideText += "_";
            }

            _text = hideText;
            _isHidden = true;
        }
    }
}