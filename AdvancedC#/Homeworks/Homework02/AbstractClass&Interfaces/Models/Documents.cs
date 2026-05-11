using AbstractClass_Interfaces.Interfaces;

namespace AbstractClass_Interfaces.Models
{
    public class Documents : ISearchable
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public bool Search(string word)
        {
            var isFoundWord = Content.Contains(word,StringComparison.OrdinalIgnoreCase);
            return isFoundWord;
        }
    }
}
