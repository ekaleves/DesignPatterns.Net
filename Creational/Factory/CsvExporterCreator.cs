namespace DesignPatterns.Net.Creational.Factory;

public class CsvExporterCreator : ExporterCreator
{
    public override IExportable CreateExporter() => new CsvExporter();
}