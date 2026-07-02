using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities.Core.Helpers
{
    public class FileMetadataReader
    {
        public static FileInfo GetMetadata(string filePath)
        {
            return new FileInfo(filePath);
        }

    }
}
