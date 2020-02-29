using System.Collections.Generic;

namespace DiscountPoolBackbone.SocialNetworsHandling
{
    public class ParsingResult
    {
        public int Id { get; set; }
        public string RawHtml { get; set; }
        public string AbsoluteUri { get; set; }
        public string[] PageInternalLinks { get; set; }
        public Dictionary<string, string> XPathesExprsResults { get; set; } //ключ - xpath, велью - результат
    }
}
