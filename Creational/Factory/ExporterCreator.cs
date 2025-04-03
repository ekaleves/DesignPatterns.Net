using System.Collections.Generic;

namespace DesignPatterns.Net.Creational.Factory;

public abstract class ExporterCreator
{
    public abstract IExportable CreateExporter();

    public string ExportAll(IEnumerable<IEnumerable<string>> items)
    {
        var exporter = CreateExporter();
        return exporter.ExportAll(items);
    }

}