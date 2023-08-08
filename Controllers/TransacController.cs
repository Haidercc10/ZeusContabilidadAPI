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
                              Proveedor = tr.Nittra == "0" ? "N/A" : (from pr in _context.Set<Tercero>() where pr.Idtercero == tr.Nittra select pr.Nombreter).FirstOrDefault(),
                          };

            if (transac == null) return BadRequest("No se encontraron registros de búsqueda!");
            return Ok(transac);
        }

        //CONSULTA QUE DEVOLVERÁ EL TOTAL DE COSTO DE LAS COMPRAS EN CADA MES EN UN AÑO QUE LE SEA PASADO
        [HttpPost("getCostos_Compras_Mes_Mes/{anio}/{inver}")]
        public IActionResult GetCostos_Compras_Mes_Mes([FromBody] List<string> facturas, string anio, string inver)
        {
#pragma warning disable CS8604 // Posible argumento de referencia nulo
            var cuentas14 = new List<string>();
            cuentas14.Add("140505");
            cuentas14.Add("140510");

            var invergoal_inversuez = new List<string>();
            invergoal_inversuez.Add("900362200");
            invergoal_inversuez.Add("900458314");

            var con = from T1 in _context.Set<Transac>()
                      where cuentas14.Contains(T1.Codicta) &&
                            T1.Idfuente == "EA" &&
                            T1.Anotra.StartsWith(anio) &&
                            (invergoal_inversuez.Contains(inver) ? inver == T1.Nittra : !invergoal_inversuez.Contains(T1.Nittra)) &&
                            (from T2 in _context.Set<Transac>()
                             where !facturas.Contains(T2.Numefac)
                             select T2.Numdoctra).Contains(T1.Numdoctra)
                      group T1 by new
                      {
                          T1.Anotra,
                      } into T
                      select new
                      {
                          Periodo = T.Key.Anotra,
                          Costo = T.Sum(x => x.Valortra)
                      };

            return con.Any() ? Ok(con) : NotFound($"No se encontró información del año {anio}");
#pragma warning restore CS8604 // Posible argumento de referencia nulo
        }

        //CONSULTA QUE VA A DEVOLVER LOS COSTOS DE LAS COMPRAS AGRUPADOS POR PROVEEDOR, AÑO Y MES
        [HttpPost("getCostos_Compras_Proveedores_Mes_Mes/{anio}/{inver}")]
        public ActionResult GetCostos_Compras_Proveedores_Mes_Mes([FromBody] List<string> facturas, string anio, string inver)
        {
            var cuentas14 = new List<string>();
            cuentas14.Add("140505");
            cuentas14.Add("140510");

            var cuentas22 = new List<string>();
            cuentas22.Add("220505");
            cuentas22.Add("220510");

            var invergoal_inversuez = new List<string>();
            invergoal_inversuez.Add("900362200");
            invergoal_inversuez.Add("900458314");

#pragma warning disable CS8604 // Posible argumento de referencia nulo
            var con = from T1 in _context.Set<Transac>()
                      join T2 in _context.Set<Transac>() on T1.Numdoctra equals T2.Numdoctra
                      join P in _context.Set<Proveedore>() on T1.Nittra equals P.Idprove
                      where !facturas.Contains(T1.Numefac) &&
                            T1.Idfuente == "EA" &&
                            cuentas22.Contains(T1.Codicta) &&
                            cuentas14.Contains(T2.Codicta) &&
                            T1.Anotra.StartsWith(anio) &&
                            (invergoal_inversuez.Contains(inver) ? inver == T1.Nittra : !invergoal_inversuez.Contains(T1.Nittra)) &&
                            T2.Numdoctra == (from T3 in _context.Set<Transac>()
                                              join T4 in _context.Set<Transac>() on T3.Numdoctra equals T4.Numdoctra
                                              where T3.Idfuente == "EA" &&
                                                    cuentas22.Contains(T3.Codicta) &&
                                                    cuentas14.Contains(T4.Codicta) &&
                                                    T3.Anotra.StartsWith(anio) &&
                                                    (invergoal_inversuez.Contains(inver) ? inver == T1.Nittra : !invergoal_inversuez.Contains(T1.Nittra)) &&
                                                    T3.Numefac == T1.Numefac
                                              select T4.Numdoctra).Max()
                      group new { T1, T2, P } by new
                      {
                          Periodo = T1.Anotra,
                          Fuente = T1.Idfuente,
                          Cuenta1 = T1.Codicta,
                          Cuenta2 = T2.Codicta,
                          Id_Proveedor = P.Idprove,
                          Proveedor = P.Razoncial
                      } into T
                      where T.Sum(x => x.T2.Valortra) > 0 
                      select new
                      {
                          T.Key.Periodo,
                          T.Key.Fuente,
                          T.Key.Cuenta2,
                          T.Key.Id_Proveedor,
                          T.Key.Proveedor,
                          Costo = T.Sum(x => x.T2.Valortra)
                      };
#pragma warning restore CS8604 // Posible argumento de referencia nulo

            return con.Any() ? Ok(con) : NotFound($"No se encontró información del año {anio}");
        }

        //CONSULTA QUE VA A DEVOLVER LOS COSTOS DE LAS COMPRAS AGRUPADOS POR FACTURA, AÑO Y MES
        [HttpPost("getCostos_Compras_Facturas_Mes_Mes/{anio}/{inver}")]
        public ActionResult GetCostos_Compras_Facturas_Mes_Mes([FromBody] List<string> facturas, string anio, string inver)
        {
            var cuentas14 = new List<string>();
            cuentas14.Add("140505");
            cuentas14.Add("140510");

            var cuentas22 = new List<string>();
            cuentas22.Add("220505");
            cuentas22.Add("220510");

            var invergoal_inversuez = new List<string>();
            invergoal_inversuez.Add("900362200");
            invergoal_inversuez.Add("900458314");

#pragma warning disable CS8604 // Posible argumento de referencia nulo
            var con = from T1 in _context.Set<Transac>()
                      join T2 in _context.Set<Transac>() on T1.Numdoctra equals T2.Numdoctra
                      join P in _context.Set<Proveedore>() on T1.Nittra equals P.Idprove
                      where !facturas.Contains(T1.Numefac) &&
                            T1.Idfuente == "EA" &&
                            cuentas22.Contains(T1.Codicta) &&
                            cuentas14.Contains(T2.Codicta) &&
                            T1.Anotra.StartsWith(anio) &&
                            (invergoal_inversuez.Contains(inver) ? inver == T1.Nittra : !invergoal_inversuez.Contains(T1.Nittra)) &&
                            T2.Numdoctra == (from T3 in _context.Set<Transac>()
                                              join T4 in _context.Set<Transac>() on T3.Numdoctra equals T4.Numdoctra
                                              where T3.Idfuente == "EA" &&
                                                    cuentas22.Contains(T3.Codicta) &&
                                                    cuentas14.Contains(T4.Codicta) &&
                                                    T3.Anotra.StartsWith(anio) &&
                                                    (invergoal_inversuez.Contains(inver) ? inver == T1.Nittra : !invergoal_inversuez.Contains(T1.Nittra)) &&
                                                    T3.Numefac == T1.Numefac
                                              select T4.Numdoctra).Max()
                      group new { T1, T2, P } by new
                      {
                          Periodo = T1.Anotra,
                          Fuente = T1.Idfuente,
                          Cuenta1 = T1.Codicta,
                          Cuenta2 = T2.Codicta,
                          Id_Proveedor = P.Idprove,
                          Proveedor = P.Razoncial,
                          Factura = T1.Numefac,
                          Fecha_Factura = T1.Fechafact,
                          Fecha_Vencimiento = T1.Vencefac,
                          Valor1 = T1.Valortra
                      } into T
                      where T.Sum(x => x.T2.Valortra) > 0
                      select new
                      {
                          T.Key.Periodo,
                          T.Key.Fuente,
                          T.Key.Cuenta2,
                          T.Key.Id_Proveedor,
                          T.Key.Proveedor,
                          T.Key.Factura,
                          T.Key.Fecha_Factura,
                          T.Key.Fecha_Vencimiento,
                          Costo = T.Sum(x => x.T2.Valortra)
                      };
#pragma warning restore CS8604 // Posible argumento de referencia nulo

            return con.Any() ? Ok(con) : NotFound($"No se encontró información del año {anio}");
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
