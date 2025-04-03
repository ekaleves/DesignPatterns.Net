namespace DesignPatterns.Net.Creational.Factory;

public class JsonExporterCreator : ExporterCreator
{
    public override IExportable CreateExporter() => new JsonExporter();
}