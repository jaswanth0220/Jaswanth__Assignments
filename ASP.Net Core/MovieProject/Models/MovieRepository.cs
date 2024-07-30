namespace MovieProject.Models
{
    public class MovieRepository
    {
        static List<Movie> movies = new List<Movie>()
        {
            new Movie() { MovieId = 1, Title = "rrr", Actor = "ntr", Lang = "telugu", Director = "rajamouli" },
            new Movie() { MovieId = 2, Title = "kgf", Actor = "yash", Lang = "kannada", Director = "prasanth neel" },
            new Movie() { MovieId = 3, Title = "bahubali", Actor = "prabhas", Lang = "hindi", Director = "rajamouli" },
            new Movie() { MovieId = 4, Title = "kalki 2898AD", Actor = "prabhas", Lang = "hindi", Director = "Nag ashwin" },
        };

        public List<Movie> GetAllMovies()
        {
            return movies;
        }

        public Movie GetMovieByName(string Name)
        {
            return movies.Single(m => m.Title == Name);
        }

        public void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }

    }
}
