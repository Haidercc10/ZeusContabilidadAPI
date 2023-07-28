using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DBInventarioZeusAPI.Models;
using Microsoft.AspNetCore.Authorization;

namespace ContabilidadZeusAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class TercerosController : ControllerBase
    {
        private readonly ContabilidadContext _context;

        public TercerosController(ContabilidadContext context)
        {
            _context = context;
        }

        // GET: api/Terceros
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tercero>>> GetTerceros()
        {
          if (_context.Terceros == null)
          {
              return NotFound();
          }
            return await _context.Terceros.ToListAsync();
        }

        // GET: api/Terceros/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tercero>> GetTercero(string id)
        {
          if (_context.Terceros == null)
          {
              return NotFound();
          }
            var tercero = await _context.Terceros.FindAsync(id);

            if (tercero == null)
            {
                return NotFound();
            }

            return tercero;
        }

        // PUT: api/Terceros/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTercero(string id, Tercero tercero)
        {
            if (id != tercero.Idtercero)
            {
                return BadRequest();
            }

            _context.Entry(tercero).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TerceroExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Terceros
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Tercero>> PostTercero(Tercero tercero)
        {
          if (_context.Terceros == null)
          {
              return Problem("Entity set 'ContabilidadContext.Terceros'  is null.");
          }
            _context.Terceros.Add(tercero);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TerceroExists(tercero.Idtercero))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTercero", new { id = tercero.Idtercero }, tercero);
        }

        // DELETE: api/Terceros/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTercero(string id)
        {
            if (_context.Terceros == null)
            {
                return NotFound();
            }
            var tercero = await _context.Terceros.FindAsync(id);
            if (tercero == null)
            {
                return NotFound();
            }

            _context.Terceros.Remove(tercero);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TerceroExists(string id)
        {
            return (_context.Terceros?.Any(e => e.Idtercero == id)).GetValueOrDefault();
        }
    }
}
