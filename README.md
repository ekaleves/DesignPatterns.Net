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

