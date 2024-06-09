using Film_library.Films;

namespace FilmLibrary.App;

public class FilmLibraryApp
{

    private readonly IFilmRepository _filmRepository;

    public FilmLibraryApp(
        IFilmRepository filmRepository )
    {
        _filmRepository = filmRepository;
    }

    string filePath = "films.json";

    public void Run()
    {

        Console.WriteLine("Welcome to the Film Library Database");
        Console.WriteLine("""1. Manage Movies Database""");
        Console.WriteLine("2. Display film details");
        Console.WriteLine("Search and filter films");
        Console.WriteLine("Categorize films");
        Console.WriteLine("Authenticate");

        Console.ReadKey();

        /*        var films = new List<Film>
                {
                    new Film { Name = "Matrix", Description = "A mind-bending thriller" },
                    new Film { Name = "Inception"}
                };

                _filmRepository.Write(filePath, films);
        */



        var readFilms = _filmRepository.Read(filePath);

        foreach (var film in readFilms)
        {
            Console.WriteLine($"{film.Name}");
        }

        Console.ReadKey();
    }

}