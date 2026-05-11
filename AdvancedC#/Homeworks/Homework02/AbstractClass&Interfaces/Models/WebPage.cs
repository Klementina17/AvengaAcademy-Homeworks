using AbstractClass_Interfaces.Interfaces;
using System.Text.RegularExpressions;

namespace AbstractClass_Interfaces.Models
{
    public class WebPage : ISearchable
    {
        public string Url { get; set; }
        public string Html { get; set; }

        public bool Search(string word)
        {
            string cleanText = Regex.Replace(Html, "<.*?>", "");
            return cleanText.Contains(word, StringComparison.OrdinalIgnoreCase);
        }
    }
}
