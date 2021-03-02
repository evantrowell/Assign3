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

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Director { get => director; set => director = value; }
    }
}