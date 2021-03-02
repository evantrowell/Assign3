using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace MovieApp.Data.ConnectionHandler
{
    public class Connections
    {
        private static readonly string connectionString;

        static Connections()
        {
            connectionString = WebConfigurationManager.ConnectionStrings["MoviesConnectionString"].ConnectionString;
        }
        public static string ConnectionString()
        {
            return connectionString;
        }
    }
}