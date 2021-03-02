using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieApp.Data;

namespace MovieApp.MovieUtils
{
    public class MovieUtilities
    {
        public static List<Movie> SelectAll()
        {
            MovieData md = new MovieData();
            return md.MovieSelectAll();
        }

        public void UpdateMovie (int id, string title, string director)
        {
            Movie MovieToUpdate = new Movie(id, title, director);
            MovieData md = new MovieData();
            md.MovieUpdate(MovieToUpdate);
        }

        public void AddMovie (string title, string director)
        {
            MovieData md = new MovieData();
            md.MovieAdd(title, director);
        }

        public void DeleteMovie (int id)
        {
            MovieData md = new MovieData();
            md.MovieDelete(id);
        }
    }
}