using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XmlParserTask.Business.Contracts.Models
{
    public class DataModel
    {
        public IList<Dictionary<string, string>> Items { get; set; } = new List<Dictionary<string, string>>();

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            foreach(var item in Items)
            {
                var element = item.Select(e => $"{e.Key} - {e.Value}");

                stringBuilder.AppendJoin(Environment.NewLine, element)
                    .AppendLine()
                    .Append(Environment.NewLine);
            }

           return stringBuilder.ToString();
        }
    }
}
