using System.Text;
using System.Collections.Generic;
using System.Linq;
 
namespace DesignPatterns.Net.Creational.Factory;
 
public class CsvExporter : IExportable
{
    public string ExportAll(IEnumerable<IEnumerable<string>> items)
    {
        if (items == null)
            return string.Empty;

        var csvBuilder = new StringBuilder();
        foreach (var row in items)
        {
            csvBuilder.AppendLine(string.Join(",", row ?? Enumerable.Empty<string>()));
        }
        return csvBuilder.ToString();
    }
 
    public IEnumerable<string> Export(IEnumerable<IEnumerable<string>> items)
    {
        if (items == null)
            yield break;
 
        foreach (var row in items)
        {
            yield return string.Join(",", row ?? Enumerable.Empty<string>());
        }
    }
}