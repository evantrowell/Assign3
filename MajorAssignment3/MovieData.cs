using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using MovieApp.Data.ConnectionHandler;
using MovieApp.MovieUtils;

namespace MovieApp.Data
{
    public class MovieData
    {
        public List<Movie> MovieSelectAll()
        {
            List<Movie> movies = new List<Movie>();
            SqlConnection connection = new SqlConnection(Connections.ConnectionString());
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT Id, Title, Director FROM Movies";

            using (connection) {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    movies.Add(new Movie(
                        (int)reader["Id"],
                        (string)reader["Title"],
                        (string)reader["Director"]));
                }
            }
            return movies;
        }

        public void MovieUpdate (Movie MovieToUpdate)
        {
            SqlConnection connection = new SqlConnection(Connections.ConnectionString());
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "UPDATE Movies SET Title=@Title, Director=@Director WHERE Id=@Id";
            command.Parameters.AddWithValue("@Title", MovieToUpdate.Title);
            command.Parameters.AddWithValue("@Director", MovieToUpdate.Director);
            command.Parameters.AddWithValue("@Id", MovieToUpdate.Id);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        
        public void MovieDelete (int id)
        {
            SqlConnection connection = new SqlConnection(Connections.ConnectionString());
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "DELETE FROM Movies WHERE Id=@Id";
            command.Parameters.AddWithValue("@Id", id);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void MovieAdd (string title, string director)
        {
            SqlConnection connection = new SqlConnection(Connections.ConnectionString());
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO Movies(Title, Director) VALUES (@Title, @Director)";
            command.Parameters.AddWithValue("@Title", title);
            command.Parameters.AddWithValue("@Director", director);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}