using System.Threading.Tasks;
using XmlParserTask.Business.Contracts.Models;

namespace XmlParserTask.Business.Contracts.Interfaces
{
    public interface IDataExporter
    {
        public Task Export(string path, DataModel data);
    }
}
