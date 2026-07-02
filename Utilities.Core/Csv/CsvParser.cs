using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities.Core.Csv
{
    public class CsvParser
    {
        public static IEnumerable<string[]> Parse(string filePath)
        {
            foreach (var line in File.ReadLines(filePath))
            {
                yield return line.Split(',');
            }
        }
    }
}
