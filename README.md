# Design Patterns in .NET

This repository demonstrates various design patterns implemented in C# using .NET 9.0. The project serves as a learning resource and reference for implementing common design patterns in C# applications.

## Design Patterns Implemented

### Creational Patterns

#### Factory Pattern
- **Purpose**: Provides an interface for creating objects without specifying their exact classes
- **Implementation**: 
  - `IExportable`: Interface defining the contract for export operations
  - `CsvExporter`: Concrete implementation for CSV export functionality
  - `ExporterCreator`: Abstract factory class for creating exporters
  - `CsvExporterCreator`: Concrete factory for creating CSV exporters

## Project Structure

```
DesignPatterns.Net/
├── Creational/
│   └── Factory/
│       ├── IExportable.cs
│       ├── CsvExporter.cs
│       ├── ExporterCreator.cs
│       └── CsvExporterCreator.cs
├── Program.cs
├── DesignPatterns.Net.csproj
└── DesignPatterns.Net.sln
```

## Prerequisites

- .NET 9.0 SDK or later
- An IDE (Visual Studio, VS Code, or Rider)

## Getting Started

1. Clone the repository:
   ```bash
   git clone https://github.com/ekaleves/DesignPatterns.Net.git
   ```

2. Navigate to the project directory:
   ```bash
   cd DesignPatterns.Net
   ```

3. Build and run the project:
   ```bash
   dotnet build
   dotnet run
   ```

## Usage Example

```csharp
// Create sample data
var data = new List<List<string>>
{
    new List<string> { "Name", "Age", "City" },
    new List<string> { "John", "30", "New York" },
    new List<string> { "Jane", "25", "San Francisco" }
};

// Create and use the CSV exporter
var exporter = new CsvExporter();

// Export all data at once
string csvAll = exporter.ExportAll(data);

// Export data row by row
foreach (var row in exporter.Export(data))
{
    Console.WriteLine(row);
}
```

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## License

This project is licensed under the MIT License - see the LICENSE file for details.

## Author

- Erika Leves
- GitHub: [ekaleves](https://github.com/ekaleves) 