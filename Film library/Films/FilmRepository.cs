using Film_library.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_library.Films
{
    public class FilmRepository : IFilmRepository
    {
        private readonly IDataRepository _stringsRepository;


        public FilmRepository(IDataRepository dataRepository)
        {
            _stringsRepository = dataRepository;
        }


        public List<Film> Read(string filePath)
        {
            List<Film> filmsFromFile = _stringsRepository.Read<Film>(filePath);
            return filmsFromFile;

        }

        private Film FilmFromString(string filmFromFile)
        {
            throw new NotImplementedException();
        }

        public void Write(string filePath, List<Film> allFilms)
        {
            _stringsRepository.Write(filePath, allFilms);
        }


    }
}
