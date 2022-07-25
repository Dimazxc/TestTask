using System;
using System.IO;

namespace XmlParserTask.Common.Contants
{
    public static class IOConstants
    {
        public const string XmlRootTagName = "item"; 

        public static string GetPathToFile(string path)
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, path);
        }
    }
}
