using Film_library.DataAccess;
using Film_library.Films;
using FilmLibrary.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


IDataRepository dataRepository = new DataRepository();

var filmLibraryApp = new FilmLibraryApp(
    new FilmRepository(dataRepository));

filmLibraryApp.Run();