
using System.Collections.Generic;

namespace WPF_Movie_List_Redone
{
    public static class GenreController
    {
        private static List<Genre> _allGenres = new List<Genre>();

        public static void addGenre(Genre newGenre)
        {
            if (!_allGenres.Contains(newGenre))
            {
                _allGenres.Add(newGenre);
            }
        }

        public static void addPresetGenres()
        {
            Genre Action = new Genre("Action");
            Genre Romance = new Genre("Romance");


            addGenre(Action);
            addGenre(Romance);
        } 

        public static List<Genre> getAllGenres()
        {
            return _allGenres;
        }

        public static bool genreExists(Genre genre)
        {
            return _allGenres.Contains(genre);
        }
    }
}
