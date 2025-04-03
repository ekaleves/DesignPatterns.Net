using System.Text;
using System.Collections.Generic;
 
namespace DesignPatterns.Net.Creational.Factory;
 
public class CsvExporter : IExportable
{
    private const string Separator = ";";
    public string ExportAll(IEnumerable<IEnumerable<string>> items)
    {
        if (items == null)
            return string.Empty;

        var csvBuilder = new StringBuilder();
        foreach (var row in items)
        {
            csvBuilder.AppendLine(string.Join(Separator, row ?? []));
        }
        return csvBuilder.ToString();
    }
 
}