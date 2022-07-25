namespace XmlParserTask.Common.Contants
{
    public static class XmlRegexConstants
    {
        public const string TagPattern = @"<([\w]*)>(.*?)<\/[\w]*>";

        public const int NameIndex = 1;

        public const int ValueIndex = 2;

        public static string GetRootTagPattern(string rootName)
        {
            return "<" + rootName + ">(.*?)</" + rootName + ">";
        }
    }
}
