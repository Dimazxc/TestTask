using System.Collections.Generic;
using System.Threading.Tasks;
using XmlParserTask.Business.Contracts.Models;

namespace XmlParserTask.Business.Contracts.Interfaces
{
    public interface IXmlParser
    {
        Task<DataModel> ParseAsync(string path, string rootName);
    }
}
