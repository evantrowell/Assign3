using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieApp.MovieUtils
{
    public class Movie
    {
        private int id;
        private string title;
        private string director;

        public Movie(int id, string title, string director)
        {
            Id = id;
            Title = title;
            Director = director;
        }

        public int Id { get; }
        public string Title { get; }
        public string Director { get; }
    }
}