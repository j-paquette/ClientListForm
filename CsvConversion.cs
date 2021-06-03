using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientListForm
{
    /// <summary>
    /// Convert text containing commas before exporting to .csv file
    /// </summary>
    /// <param name="str">String to output </param>
    /// <returns>The csv cell formatted string</returns>
    public class CsvConversion
    {
        //Got the code snippet from here: https://stackoverflow.com/questions/6377454/escaping-tricky-string-to-csv-format
        public static string ConvertStringToCsv(string str)
        {
            bool stringContains = (str.Contains(",")) || (str.Contains("\"")) || (str.Contains("\r")) || (str.Contains("\n"));
            if (stringContains)
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append("\"");
                foreach (char nextChar in str)
                {
                    stringBuilder.Append(nextChar);
                    if (nextChar == '"')
                        stringBuilder.Append("\"");
                }
                stringBuilder.Append("\"");
                return stringBuilder.ToString();
            }
            return str;
        }
    }
}
