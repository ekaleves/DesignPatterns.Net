using System;
using DesignPatterns.Net.Creational.Factory;
using System.IO;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var movieDomain = new MovieDomain();
        
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MoviesLineByLine.csv");
        movieDomain.ExportToCsv(filePath);

        filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Movies.csv");
        movieDomain.ExportAllToCsv(filePath);
    }
}