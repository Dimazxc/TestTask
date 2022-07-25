using System;
using System.IO;
using System.Threading.Tasks;
using XmlParserTask.Business.Contracts.Interfaces;
using XmlParserTask.Business.Contracts.Models;

namespace XmlParserTask.Business.Internal.XmlParsers.Base
{
    public abstract class BaseXmlParser : IXmlParser
    {
        public async Task<DataModel> ParseAsync(string path, string rootName)
        {
            using var streamReader = new StreamReader(path);
            var content = (await streamReader.ReadToEndAsync())
                .Replace(Environment.NewLine, string.Empty);
            streamReader.Close();

            return ParseXml(content, rootName);
        }

        public abstract DataModel ParseXml(string xmlDocumentContent, string rootName);
    }
}
