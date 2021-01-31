using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Api.Data;
using Api.Models;
using System.Linq;
using System;

namespace Api.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class MovieController: ControllerBase
    {
        private readonly DataContext _context;

        public MovieController(DataContext context)
        {
            this._context = context;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult> GetMovies()
        {
            var filmes = await _context.movies.Include(x => x.Images).ToListAsync();
            return Ok(filmes);
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult> addMovie([FromBody]Movie movie)
        {    
            Console.WriteLine("Entrei aqui");
            try{
                var exists = _context.movies.Where(x => x.Title.ToLower() == movie.Title.ToLower()).FirstOrDefault();
                if(exists != null){
                    return Conflict("Movie already cadastered.");
                }
                _context.Add(movie);
                _context.SaveChanges();
                return Ok(movie);
            } catch {
                return StatusCode(500, "Internal server error...");
            }
        }
    }
}