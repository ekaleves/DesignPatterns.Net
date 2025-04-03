using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
 
namespace DesignPatterns.Net.Creational.Factory;
 
public class JsonExporter : IExportable
{
    private readonly JsonSerializerOptions _jsonOptions = new() { WriteIndented = true };
 
    public string ExportAll(IEnumerable<IEnumerable<string>> items)
    {
        if (items == null || !items.Any())
            return "[]";
 
        var headers = items.First().ToArray();
        var jsonArray = items.Skip(1).Select(row =>
        {
            var movies = new Dictionary<string, string>();
            var currentMovie = row.ToArray();
            for (int i = 0; i < headers.Length && i < currentMovie.Length; i++)
            {
                movies[headers[i]] = currentMovie[i];
            }
            return movies;
        });
 
        return JsonSerializer.Serialize(jsonArray, _jsonOptions);
    }
 
}