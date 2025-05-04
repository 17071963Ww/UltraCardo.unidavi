using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UltraCardo.API.Data;
using UltraCardo.API.Models;

namespace UltraCardo.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FreteController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FreteController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Frete>>> GetAll()
        {
            return await _context.Fretes.Include(f => f.Produto).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Frete>> GetById(int id)
        {
            var frete = await _context.Fretes.Include(f => f.Produto).FirstOrDefaultAsync(f => f.Id == id);
            return frete == null ? NotFound() : frete;
        }

        [HttpPost]
        public async Task<ActionResult<Frete>> Post(Frete frete)
        {
            _context.Fretes.Add(frete);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = frete.Id }, frete);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Frete frete)
        {
            if (id != frete.Id) return BadRequest();

            _context.Entry(frete).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var frete = await _context.Fretes.FindAsync(id);
            if (frete == null) return NotFound();

            _context.Fretes.Remove(frete);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
