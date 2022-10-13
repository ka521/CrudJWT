using CrudJWT.Models;

namespace CrudJWT.Services
{
    public interface IMovieService
    {
        public Movie Get(int id);
            public Movie Create(Movie movie);
        public List<Movie> List();
        public bool Delete(int id); 
        public Movie Update(Movie movie);    
    }
}
