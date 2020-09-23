using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI
{
   [Table("Movies")]
    public class Movie
    {
        
        [Key]
        public int MovieID { get; set; }
        public string Title { get; set; }
        public string Starring { get; set; }
        public string ReleaseDate { get; set; }
        public string Runtime { get; set; }
        public string Category { get; set; }

        public static List<Movie> Read()
        {
            IDbConnection db = new SqlConnection("Server=4797Q13;Database=Movies;user id=sa; password=Inari2007");

            List<Movie> movie = db.Query<Movie>($"select * from Movies").AsList();

            return movie;
        }
        public static List<Movie> MoviesInCat(string category)
        {
            IDbConnection db = new SqlConnection("Server=4797Q13;Database=Movies;user id=sa; password=Inari2007");

            List<Movie> movie = db.Query<Movie>($"select * from Movies where Category LIKE '%{category}%'").AsList();

            return movie;
        }


        public static List<string> ReadCategory()
        {
            IDbConnection db = new SqlConnection("Server=4797Q13;Database=Movies;user id=sa; password=Inari2007");

            List<string> mcategory = db.Query<string>($"select DISTINCT Category FROM Movies").AsList();

            return mcategory;
        }
    }
 
    
}
