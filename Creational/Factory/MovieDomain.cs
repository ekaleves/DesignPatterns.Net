using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;
 
namespace DesignPatterns.Net.Creational.Factory;
 
public partial class MovieDomain
{
    private readonly (string Name, int Year, string Genre)[] _movies =
    [
        ("The Shawshank Redemption", 1994, "Drama"),
        ("The Godfather", 1972, "Crime"),
        ("The Dark Knight", 2008, "Action"),
        ("Pulp Fiction", 1994, "Crime"),
        ("Fight Club", 1999, "Drama"),
        ("Inception", 2010, "Sci-Fi"),
        ("The Matrix", 1999, "Sci-Fi"),
        ("Goodfellas", 1990, "Crime"),
        ("The Silence of the Lambs", 1991, "Thriller"),
        ("Forrest Gump", 1994, "Drama"),
        ("The Lord of the Rings: The Fellowship of the Ring", 2001, "Fantasy"),
        ("Star Wars: Episode IV - A New Hope", 1977, "Sci-Fi"),
        ("The Good, the Bad and the Ugly", 1966, "Western"),
        ("The Lord of the Rings: The Return of the King", 2003, "Fantasy"),
        ("Schindler's List", 1993, "Biography"),
        ("The Lord of the Rings: The Two Towers", 2002, "Fantasy"),
        ("The Godfather Part II", 1974, "Crime"),
        ("One Flew Over the Cuckoo's Nest", 1975, "Drama"),
        ("The Empire Strikes Back", 1980, "Sci-Fi"),
        ("The Lion King", 1994, "Animation"),
        ("The Departed", 2006, "Crime"),
        ("The Green Mile", 1999, "Drama"),
        ("Interstellar", 2014, "Sci-Fi"),
        ("The Pianist", 2002, "Biography"),
        ("The Usual Suspects", 1995, "Crime"),
        ("Leon: The Professional", 1994, "Action"),
        ("The Prestige", 2006, "Drama"),
        ("Gladiator", 2000, "Action"),
        ("The Sixth Sense", 1999, "Thriller"),
        ("The Terminator", 1984, "Sci-Fi"),
        ("Back to the Future", 1985, "Adventure"),
        ("The Big Lebowski", 1998, "Comedy"),
        ("The Truman Show", 1998, "Drama"),
        ("The Grand Budapest Hotel", 2014, "Comedy"),
        ("The Social Network", 2010, "Biography"),
        ("The Wolf of Wall Street", 2013, "Biography"),
        ("The Revenant", 2015, "Adventure"),
        ("The Hateful Eight", 2015, "Western"),
        ("The Shape of Water", 2017, "Drama"),
        ("The Irishman", 2019, "Crime"),
        ("Parasite", 2019, "Thriller"),
        ("1917", 2019, "War"),
        ("Joker", 2019, "Crime"),
        ("The Batman", 2022, "Action"),
        ("Everything Everywhere All at Once", 2022, "Action"),
        ("Top Gun: Maverick", 2022, "Action"),
        ("The Menu", 2022, "Horror"),
        ("Black Panther: Wakanda Forever", 2022, "Action"),
        ("Avatar: The Way of Water", 2022, "Sci-Fi"),
        ("Oppenheimer", 2023, "Biography"),
        ("Barbie", 2023, "Comedy"),
        ("Killers of the Flower Moon", 2023, "Crime"),
        ("Poor Things", 2023, "Comedy"),
        ("The Holdovers", 2023, "Comedy"),
        ("Past Lives", 2023, "Drama"),
        ("Anatomy of a Fall", 2023, "Crime"),
        ("The Zone of Interest", 2023, "Drama"),
        ("The Boy and the Heron", 2023, "Animation"),
        ("Spider-Man: Across the Spider-Verse", 2023, "Animation"),
        ("Mission: Impossible - Dead Reckoning", 2023, "Action"),
        ("John Wick: Chapter 4", 2023, "Action"),
        ("Guardians of the Galaxy Vol. 3", 2023, "Action"),
        ("Dune: Part Two", 2024, "Sci-Fi"),
        ("Civil War", 2024, "Action"),
        ("Godzilla x Kong: The New Empire", 2024, "Action"),
        ("Kung Fu Panda 4", 2024, "Animation"),
        ("Dune: Part One", 2021, "Sci-Fi"),
        ("No Time to Die", 2021, "Action"),
        ("The Power of the Dog", 2021, "Drama"),
        ("Licorice Pizza", 2021, "Comedy"),
        ("Don't Look Up", 2021, "Comedy"),
        ("The French Dispatch", 2021, "Comedy"),
        ("Last Night in Soho", 2021, "Thriller"),
        ("The Suicide Squad", 2021, "Action"),
        ("Shang-Chi and the Legend of the Ten Rings", 2021, "Action"),
        ("Eternals", 2021, "Action"),
        ("Black Widow", 2021, "Action"),
        ("Cruella", 2021, "Adventure"),
        ("A Quiet Place Part II", 2021, "Horror"),
        ("The Mitchells vs. the Machines", 2021, "Animation"),
        ("Luca", 2021, "Animation"),
        ("Encanto", 2021, "Animation"),
        ("Raya and the Last Dragon", 2021, "Animation"),
        ("The Father", 2020, "Drama"),
        ("Nomadland", 2020, "Drama"),
        ("Minari", 2020, "Drama"),
        ("Sound of Metal", 2020, "Drama"),
        ("The Trial of the Chicago 7", 2020, "Drama"),
        ("Tenet", 2020, "Action"),
        ("Soul", 2020, "Animation"),
        ("Wolfwalkers", 2020, "Animation"),
        ("Onward", 2020, "Animation"),
        ("The Croods: A New Age", 2020, "Animation"),
        ("Wonder Woman 1984", 2020, "Action"),
        ("Mulan", 2020, "Action"),
        ("The Invisible Man", 2020, "Horror"),
        ("Birds of Prey", 2020, "Action"),
        ("The Gentlemen", 2020, "Action"),
        ("Bad Boys for Life", 2020, "Action"),
        ("Sonic the Hedgehog", 2020, "Action"),
        ("The Call of the Wild", 2020, "Adventure"),
        ("Dolittle", 2020, "Adventure"),
        ("The New Mutants", 2020, "Action"),
        ("Underwater", 2020, "Horror"),
        ("The Rhythm Section", 2020, "Action"),
        ("The Way Back", 2020, "Drama"),
        ("Downhill", 2020, "Comedy"),
        ("Fantasy Island", 2020, "Horror"),
        ("The Grudge", 2020, "Horror"),
        ("Like a Boss", 2020, "Comedy"),
        ("The \nTurning", 2020, "Horror"),
        ("Me; Myself & Irene", 2000, "Comedy")
    ];
 
    private static readonly string[] headers = ["Name", "Year", "Genre"];
    

    [GeneratedRegex("""[\"\r\n]""")]
    private static partial Regex QuoteAndLineRegex();
 
    private static string CleanString(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;
 
        return QuoteAndLineRegex().Replace(input, "").Replace(";", ",");
    }
 
    private List<IEnumerable<string>> GetExportData()
    {
        var exportData = new List<IEnumerable<string>>{ headers };
 
        exportData.AddRange(_movies.Select(movie => new[]
            {
                CleanString(movie.Name),
                movie.Year.ToString(),
                CleanString(movie.Genre)
            }));
 
        return exportData;
    }
 
    public void ExportAllToCsv(string filePath)
    {
        var exporterCreator = new CsvExporterCreator();
       
        var exportData = GetExportData();
 
        string content = exporterCreator.ExportAll(exportData);
 
        File.WriteAllText(filePath, content);
    }
 
 
    public void ExportAllToJson(string filePath)
    {
        var exporterCreator = new JsonExporterCreator();
       
        var exportData = GetExportData();
 
        string content = exporterCreator.ExportAll(exportData);
 
        File.WriteAllText(filePath, content);
    }
 
}
 