using Microsoft.AspNetCore.Mvc;
using modul9_2311104074.Models;

namespace modul9_2311104074.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private static List<Movie> movies = new List<Movie>
        {
            new Movie {
                Title = "The Shawshank Redemption",
                Director = "Frank Darabont",
                Stars = new List<string> { "Tim Robbins", "Morgan Freeman", "Bob Gunton" },
                Description = "Two imprisoned men bond over a number of years."
            },
            new Movie {
                Title = "The Godfather",
                Director = "Francis Ford Coppola",
                Stars = new List<string> { "Marlon Brando", "Al Pacino", "James Caan" },
                Description = "The aging patriarch of an organized crime dynasty transfers control to his reluctant son."
            },
            new Movie {
                Title = "The Dark Knight",
                Director = "Christopher Nolan",
                Stars = new List<string> { "Christian Bale", "Heath Ledger", "Aaron Eckhart" },
                Description = "Batman sets out to dismantle the remaining criminal organizations."
            }
        };

        [HttpGet]
        public ActionResult<List<Movie>> GetAll()
        {
            return movies;
        }

        [HttpGet("{id}")]
        public ActionResult<Movie> GetById(int id)
        {
            if (id < 0 || id >= movies.Count) return NotFound("Movie not found");
            return movies[id];
        }

        [HttpPost]
        public ActionResult AddMovie([FromBody] Movie movie)
        {
            movies.Add(movie);
            return Ok("Movie added");
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteMovie(int id)
        {
            if (id < 0 || id >= movies.Count) return NotFound("Invalid index");
            movies.RemoveAt(id);
            return Ok("Movie deleted");
        }
    }
}

