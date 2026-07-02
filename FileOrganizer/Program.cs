using Utilities.Core.Helpers;
using Utilities.Core.Logging;

ConsoleLogger.Info("Scanning files...");

var files = FileScanner.GetFiles("C:\\Test");

foreach (var file in files)
{
    ConsoleLogger.Info(file);
}

ConsoleLogger.Info("Cleaning empty directories...");
DirectoryCleaner.DeleteEmptyDirectories("C:\\Test");

ConsoleLogger.Info("Done.");
