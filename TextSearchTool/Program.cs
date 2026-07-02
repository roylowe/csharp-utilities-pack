using Utilities.Core.Text;
using Utilities.Core.Logging;

ConsoleLogger.Info("Searching text...");

var matches = TextSearch.FindLinesContaining("C:\\Test\\log.txt", "error");

foreach (var line in matches)
{
    ConsoleLogger.Info(line);
}
