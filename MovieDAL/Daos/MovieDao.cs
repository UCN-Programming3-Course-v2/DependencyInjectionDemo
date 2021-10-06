using MovieDAL.Model;
using System;
using System.Collections.Generic;

namespace MovieDAL.Daos
{
    internal class MovieDao : IDao<Movie>
    {
        private static List<Movie> _movies = new()
        {
            new Movie{ Title="The Shawshank Redemption", Rating= 9.3},
            new Movie{ Title="The Godfather", Rating= 9.2},
            new Movie{ Title="The Dark Knight", Rating= 9},
            new Movie{ Title="The Godfather: Part II", Rating= 9},
            new Movie{ Title="12 Angry Men", Rating= 9},
            new Movie{ Title="The Lord of the Rings: The Return of the King", Rating= 8.9},
            new Movie{ Title="Pulp Fiction", Rating= 8.9},
            new Movie{ Title="Schindler's List", Rating= 8.9},
            new Movie{ Title="Inception", Rating= 8.8},
            new Movie{ Title="Fight Club", Rating= 8.8},
            new Movie{ Title="The Lord of the Rings: The Fellowship of the Ring", Rating= 8.8},
            new Movie{ Title="Forrest Gump", Rating= 8.8},
            new Movie{ Title="The Good, the Bad and the Ugly", Rating= 8.8},
            new Movie{ Title="The Lord of the Rings: The Two Towers", Rating= 8.7},
            new Movie{ Title="The Matrix", Rating= 8.7}
        };

        public IEnumerable<Movie> GetAll()
        {
            return _movies;
        }
    }
}
