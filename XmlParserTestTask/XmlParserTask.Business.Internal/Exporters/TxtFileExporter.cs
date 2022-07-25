using System.IO;
using System.Threading.Tasks;
using XmlParserTask.Business.Contracts.Interfaces;
using XmlParserTask.Business.Contracts.Models;

namespace XmlParserTask.Business.Internal.Exporters
{
    public class TxtFileExporter : IDataExporter
    {
        public async Task Export(string path, DataModel data)
        {
            var dataToWrite = data.ToString();

            using var streamWriter = new StreamWriter(path);
            await streamWriter.WriteAsync(dataToWrite);

            await streamWriter.DisposeAsync();
        }
    }
}
