using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities.Core.Helpers
{
    public class FileScanner
    {
        public static IEnumerable<string> GetFiles(string path, string searchPattern = "*.*")
        {
            return Directory.EnumerateFiles(path, searchPattern, SearchOption.AllDirectories);
        }
    }
}
