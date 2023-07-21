using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DBInventarioZeusAPI.Models;

namespace ContabilidadZeusAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaldocontBuController : ControllerBase
    {
        private readonly ContabilidadContext _context;

        public SaldocontBuController(ContabilidadContext context)
        {
            _context = context;
        }

        // GET: api/SaldocontBu
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SaldocontBu>>> GetSaldocontBus()
        {
          if (_context.SaldocontBus == null)
          {
              return NotFound();
          }
            return await _context.SaldocontBus.ToListAsync();
        }

        // GET: api/SaldocontBu/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SaldocontBu>> GetSaldocontBu(string id)
        {
          if (_context.SaldocontBus == null)
          {
              return NotFound();
          }
            var saldocontBu = await _context.SaldocontBus.FindAsync(id);

            if (saldocontBu == null)
            {
                return NotFound();
            }

            return saldocontBu;
        }

        // PUT: api/SaldocontBu/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSaldocontBu(string id, SaldocontBu saldocontBu)
        {
            if (id != saldocontBu.Anomescta)
            {
                return BadRequest();
            }

            _context.Entry(saldocontBu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SaldocontBuExists(id))
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

        // POST: api/SaldocontBu
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SaldocontBu>> PostSaldocontBu(SaldocontBu saldocontBu)
        {
          if (_context.SaldocontBus == null)
          {
              return Problem("Entity set 'ContabilidadContext.SaldocontBus'  is null.");
          }
            _context.SaldocontBus.Add(saldocontBu);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SaldocontBuExists(saldocontBu.Anomescta))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSaldocontBu", new { id = saldocontBu.Anomescta }, saldocontBu);
        }

        // DELETE: api/SaldocontBu/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSaldocontBu(string id)
        {
            if (_context.SaldocontBus == null)
            {
                return NotFound();
            }
            var saldocontBu = await _context.SaldocontBus.FindAsync(id);
            if (saldocontBu == null)
            {
                return NotFound();
            }

            _context.SaldocontBus.Remove(saldocontBu);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SaldocontBuExists(string id)
        {
            return (_context.SaldocontBus?.Any(e => e.Anomescta == id)).GetValueOrDefault();
        }
    }
}
