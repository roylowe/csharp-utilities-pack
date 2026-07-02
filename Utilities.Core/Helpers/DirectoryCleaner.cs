using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities.Core.Helpers
{
    public class DirectoryCleaner
    {
        public static void DeleteEmptyDirectories(string rootPath)
        {
            foreach (var dir in Directory.GetDirectories(rootPath))
            {
                DeleteEmptyDirectories(dir);

                if (!Directory.EnumerateFileSystemEntries(dir).Any())
                {
                    Directory.Delete(dir);
                }
            }
        }
    }
}

