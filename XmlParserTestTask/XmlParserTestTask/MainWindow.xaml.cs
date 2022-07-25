using System.Threading.Tasks;
using System.Windows;
using XmlParserTask.Business.Contracts.Interfaces;
using XmlParserTask.Business.Contracts.Models;
using XmlParserTask.Business.Internal.Exporters;
using XmlParserTask.Business.Internal.XmlParsers;
using XmlParserTask.Common.Contants;

namespace XmlParserTestTask
{
    public partial class MainWindow : Window
    {
        private IXmlParser xmlParser;
        private IDataExporter dataExporter;
        private DataModel dataModel;

        public MainWindow()
        {
            InitializeComponent();

            dataModel = new DataModel();
            dataExporter = new TxtFileExporter();
        }

        private async void RegexParseXml_Click(object sender, RoutedEventArgs e)
        {
            this.xmlParser = new RegexXmlParser();

            await ExecuteParseAction();
        }

        private async void DataModelParseXml_Click(object sender, RoutedEventArgs e)
        {
            this.xmlParser = new DataModelXmlParser();

            await ExecuteParseAction();
        }

        private async void WriteToTxtButton_Click(object sender, RoutedEventArgs e)
        {
            await dataExporter.Export("test.txt", dataModel);
        }

        private async Task ExecuteParseAction()
        {
            dataModel = await xmlParser.ParseAsync(IOConstants.GetPathToFile("data.xml"), IOConstants.XmlRootTagName);
        }
    }
}