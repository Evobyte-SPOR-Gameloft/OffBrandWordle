using WordNamespace;

namespace GuessedWordNamespace
{
    class GuessedWord : Word
    {
        private readonly string _WordValue;

        public GuessedWord(string WordValue)
        {
            _WordValue = WordValue;
        }

        public override string WordValue
        {
            get { return _WordValue; }
        }
    }
}
