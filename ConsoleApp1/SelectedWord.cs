using WordNamespace;

namespace SelectedWordNamespace
{
    class SelectedWord : Word
    {
        private readonly string _WordValue;

        public SelectedWord(string WordValue)
        {
            _WordValue = WordValue;
        }

        public override string WordValue
        {
            get { return _WordValue; }
        }
    }
}
