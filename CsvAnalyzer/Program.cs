using Utilities.Core.Csv;
using Utilities.Core.Logging;

ConsoleLogger.Info("Analyzing CSV...");

var rows = CsvParser.Parse("C:\\Test\\data.csv");

foreach (var row in rows)
{
    ConsoleLogger.Info(string.Join(" | ", row));
}
