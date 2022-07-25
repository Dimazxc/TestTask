using System.Linq;
using System.Xml.Linq;
using XmlParserTask.Business.Contracts.Interfaces;
using XmlParserTask.Business.Contracts.Models;
using XmlParserTask.Business.Internal.XmlParsers.Base;

namespace XmlParserTask.Business.Internal.XmlParsers
{
    public class DataModelXmlParser : BaseXmlParser
    {
        public override DataModel ParseXml(string xmlDocumentContent, string rootName)
        {
            var xmlDocument = XDocument.Parse(xmlDocumentContent);
            var xmlResult = new DataModel();

            foreach (var node in xmlDocument.Descendants(rootName))
            {
                var parsedNode = node.Elements().ToDictionary(node => node.Name.LocalName, node => node.Value);

                xmlResult.Items.Add(parsedNode);
            }

            return xmlResult;
        }
    }
}
