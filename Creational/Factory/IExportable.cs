using System.Collections.Generic;

namespace DesignPatterns.Net.Creational.Factory;

public interface IExportable
{
    string ExportAll(IEnumerable<IEnumerable<string>> items);
    IEnumerable<string> Export(IEnumerable<IEnumerable<string>> items);
}