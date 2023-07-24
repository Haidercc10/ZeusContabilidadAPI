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
    public class TransacController : ControllerBase
    {
        private readonly ContabilidadContext _context;

        public TransacController(ContabilidadContext context)
        {
            _context = context;
        }

        // GET: api/Transac
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Transac>>> GetTransacs()
        {
          if (_context.Transacs == null)
          {
              return NotFound();
          }
            return await _context.Transacs.ToListAsync();
        }

        // GET: api/Transac/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Transac>> GetTransac(int id)
        {
          if (_context.Transacs == null)
          {
              return NotFound();
          }
            var transac = await _context.Transacs.FindAsync(id);

            if (transac == null)
            {
                return NotFound();
            }

            return transac;
        }

        // GET: api/Transac/5
        [HttpGet("getCostosCuentasxMesDetallada/{anio}/{mes}")]
        public ActionResult GetCostosCuentasxMesDetallada(string anio, string mes)
        {
            if (_context.Transacs == null) return NotFound();

            //if (mes.ToString().Length > 1) mes = $"{mes}";
            //else mes = $"0{mes}";

            var transac = from tr in _context.Set<Transac>()
                          from fu in _context.Set<Fuente>()
                          from ec in _context.Set<EscenariosCuenta>()
                          where tr.Idfuente == fu.Idfuente &&
                          tr.Codicta == ec.Id &&
                          (tr.Codicta.StartsWith("51") ||
                          tr.Codicta.StartsWith("52") ||
                          tr.Codicta.StartsWith("53") ||
                          tr.Codicta.StartsWith("72") ||
                          tr.Codicta.StartsWith("73") ||
                          tr.Codicta.StartsWith("74")) &&
                          tr.Statustra == "AC" &&
                          tr.Anotra == $"{anio}{mes}"
                          orderby tr.Codicta descending
                          select new
                          {
                              Periodo = tr.Anotra,
                              Id_Fuente = tr.Idfuente,
                              Fuente = fu.Desfuente,
                              Documento = tr.Numdoctra,
                              Consecutivo = tr.Consecutra,
                              Fecha_Transaccion = tr.Fechatra,
                              Id_Cuenta = tr.Codicta,
                              Cuenta = ec.Nombre,
                              Descripcion_Transaccion = tr.Descritra,
                              Valor = tr.Valortra,
                              Id_CentroCosto = tr.Idcenco,
                              Centro_Costo = tr.Idcenco == "" ? "N/A" : (from cc in _context.Set<CcmCentroCosto>() where cc.CodigoCentroCosto == tr.Idcenco select cc.DescripcionCentroCosto).FirstOrDefault(),
                              Fecha_Grabacion = tr.Fgratra,
                              Estado = tr.Statustra,
                              Origen_Mov = tr.IdOrigenMovimiento,
                              Id_Proveedor = tr.Nittra,
                              Proveedor = tr.Nittra == "0" ? "N/A" : (from pr in _context.Set<Proveedore>() where pr.Idprove == tr.Nittra select pr.Razoncial).FirstOrDefault(),
                          };

            if (transac == null) return BadRequest("No se encontraron registros de búsqueda!");
            return Ok(transac);
        }

        [HttpGet("getCostosCuentasxMesDetallada/{anio}/{mes}/{cuenta}")]
        public ActionResult GetCostosCuentasxMesDetallada(string anio, string mes, string cuenta)
        {
            if (_context.Transacs == null) return NotFound();

            //if (mes.ToString().Length > 1) mes = $"{mes}";
            //else mes = $"0{mes}";

            var transac = from tr in _context.Set<Transac>()
                          from fu in _context.Set<Fuente>()
                          from ec in _context.Set<EscenariosCuenta>()
                          where tr.Idfuente == fu.Idfuente &&
                          tr.Codicta == ec.Id &&
                          tr.Codicta == cuenta &&
                          tr.Statustra == "AC" &&
                          tr.Anotra == $"{anio}{mes}"
                          orderby tr.Codicta descending
                          select new
                          {
                              Periodo = tr.Anotra,
                              Id_Fuente = tr.Idfuente,
                              Fuente = fu.Desfuente,
                              Documento = tr.Numdoctra,
                              Consecutivo = tr.Consecutra,
                              Fecha_Transaccion = tr.Fechatra,
                              Id_Cuenta = tr.Codicta,
                              Cuenta = ec.Nombre,
                              Descripcion_Transaccion = tr.Descritra,
                              Valor = tr.Valortra,
                              Id_CentroCosto = tr.Idcenco,
                              Centro_Costo = tr.Idcenco == "" ? "N/A" : (from cc in _context.Set<CcmCentroCosto>() where cc.CodigoCentroCosto == tr.Idcenco select cc.DescripcionCentroCosto).FirstOrDefault(),
                              Fecha_Grabacion = tr.Fgratra,
                              Estado = tr.Statustra,
                              Origen_Mov = tr.IdOrigenMovimiento,
                              Id_Proveedor = tr.Nittra,
                              Proveedor = tr.Nittra == "0" ? "N/A" : (from pr in _context.Set<Proveedore>() where pr.Idprove == tr.Nittra select pr.Razoncial).FirstOrDefault(),
                          };

            if (transac == null) return BadRequest("No se encontraron registros de búsqueda!");
            return Ok(transac);
        }


        // PUT: api/Transac/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTransac(int id, Transac transac)
        {
            if (id != transac.Consecutra)
            {
                return BadRequest();
            }

            _context.Entry(transac).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TransacExists(id))
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

        // POST: api/Transac
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Transac>> PostTransac(Transac transac)
        {
          if (_context.Transacs == null)
          {
              return Problem("Entity set 'ContabilidadContext.Transacs'  is null.");
          }
            _context.Transacs.Add(transac);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTransac", new { id = transac.Consecutra }, transac);
        }

        // DELETE: api/Transac/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTransac(int id)
        {
            if (_context.Transacs == null)
            {
                return NotFound();
            }
            var transac = await _context.Transacs.FindAsync(id);
            if (transac == null)
            {
                return NotFound();
            }

            _context.Transacs.Remove(transac);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TransacExists(int id)
        {
            return (_context.Transacs?.Any(e => e.Consecutra == id)).GetValueOrDefault();
        }
    }
}
