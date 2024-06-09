
namespace Film_library.Films
{
    public interface IFilmRepository
    {
        List<Film> Read(string filePath);
        void Write(string filePath, List<Film> allFilms);
    }
}