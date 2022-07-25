using System.Linq;
using System.Text.RegularExpressions;
using XmlParserTask.Business.Contracts.Models;
using XmlParserTask.Business.Internal.XmlParsers.Base;
using XmlParserTask.Common.Contants;

namespace XmlParserTask.Business.Internal.XmlParsers
{
    public class RegexXmlParser : BaseXmlParser
    {
        public override DataModel ParseXml(string xmlDocumentContent, string rootName)
        {
            var xmlResult = new DataModel();
            var matchCollection = Regex.Matches(xmlDocumentContent, XmlRegexConstants.GetRootTagPattern(rootName));

            foreach (Match match in matchCollection)
            {
                var elements = Regex.Matches(match.Groups[XmlRegexConstants.NameIndex].Value, XmlRegexConstants.TagPattern);
                var item = elements.ToDictionary(e =>
                    e.Groups[XmlRegexConstants.NameIndex].Value,
                    e => e.Groups[XmlRegexConstants.ValueIndex].Value);

                xmlResult.Items.Add(item);
            }

            return xmlResult;
        }
    }
}
