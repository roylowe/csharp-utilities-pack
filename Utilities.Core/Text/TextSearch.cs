using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities.Core.Text
{
    public class TextSearch
    {
        public static IEnumerable<string> FindLinesContaining(string filePath, string keyword)
        {
            return File.ReadLines(filePath)
                       .Where(line => line.Contains(keyword, StringComparison.OrdinalIgnoreCase));
        }
    }
}
