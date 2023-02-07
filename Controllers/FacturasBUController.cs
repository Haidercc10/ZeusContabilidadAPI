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
    public class FacturasBUController : ControllerBase
    {
        private readonly ContabilidadContext _context;

        public FacturasBUController(ContabilidadContext context)
        {
            _context = context;
        }

        // GET: api/Clientes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FacturasBu>>> GetFacturasBu()
        {
            if (_context.Clientes == null)
            {
                return NotFound();
            }
            return await _context.FacturasBus.ToListAsync();
        }

        // GET: api/Clientes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FacturasBu>> GetFacturasBu(int id)
        {
            if (_context.FacturasBus == null)
            {
                return NotFound();
            }
            var cliente = await _context.FacturasBus.FindAsync(id);

            if (cliente == null)
            {
                return NotFound();
            }

            return cliente;
        }

        //CARTERA TOTAL
        [HttpGet("getCarteraTotal")]
        public ActionResult GetCarteraTotal()
        {
            var con = from cli in _context.Set<Cliente>()
                      from vendedor in _context.Set<Maevende>()
                      from fac in _context.Set<FacturasBu>()
                      join subFac in _context.Set<FacturasBu>() on fac.Numefac equals subFac.Numefac into details
                      where fac.Sactfac > 0
                            && cli.Idcliente == fac.Idcliprv
                            && vendedor.Idvende == fac.Idvende
                            && details.Max(x => x.IdenFacturasBu) == fac.IdenFacturasBu
                      orderby fac.Numefac ascending
                      select new
                      {
                          Num_Factura = fac.Numefac,
                          Nombre_CLiente = cli.Razoncial,
                          Id_Fecha = (from fac2 in _context.Set<FacturasBu>()
                                      where fac2.Numefac == fac.Numefac
                                      orderby fac2.IdenFacturasBu ascending
                                      select fac2.Fecharadicado).FirstOrDefault(),
                          LAPSO_DOC = fac.Fechfac,
                          Fecha_Vencimiento = fac.Vencfac,
                          Nombre_Vendedor = vendedor.Nombvende,
                          Id_Vendedor = fac.Idvende,
                          Tipo_Movimiento = "FV",
                          Saldo_Cartera = fac.Sactfac,
                          Fecha_Radicado = fac.Fecharadicado,
                          TipoCliente = "05",
                          Direccion_Cliente = cli.Direccion,
                          Telefono_Cliente = cli.Telefono,
                          Id_Cliente = fac.Idcliprv,
                          Ciudad_Cliente = cli.Ciudad,
                          Plazo_De_Pago = cli.Diplazo,
                      };
            return Ok(con);
        }

        //CARTERA POR VENDEDOR
        [HttpGet("getCarteraVendedor/{id}")]
        public ActionResult GetCarteraVendedor(string id)
        {
            var con = from cli in _context.Set<Cliente>()
                      from vendedor in _context.Set<Maevende>()
                      from fac in _context.Set<FacturasBu>()
                      join subFac in _context.Set<FacturasBu>() on fac.Numefac equals subFac.Numefac into details
                      where fac.Sactfac > 0
                            && cli.Idcliente == fac.Idcliprv
                            && vendedor.Idvende == fac.Idvende
                            && details.Max(x => x.IdenFacturasBu) == fac.IdenFacturasBu
                            && fac.Idvende == id
                      orderby fac.Numefac ascending
                      select new
                      {
                          Num_Factura = fac.Numefac,
                          Nombre_CLiente = cli.Razoncial,
                          Id_Fecha = (from fac2 in _context.Set<FacturasBu>()
                                      where fac2.Numefac == fac.Numefac
                                      orderby fac2.IdenFacturasBu ascending
                                      select fac2.Fecharadicado).FirstOrDefault(),
                          LAPSO_DOC = fac.Fechfac,
                          Fecha_Vencimiento = fac.Vencfac,
                          Nombre_Vendedor = vendedor.Nombvende,
                          Id_Vendedor = fac.Idvende,
                          Tipo_Movimiento = "FV",
                          Saldo_Cartera = fac.Sactfac,
                          Fecha_Radicado = fac.Fecharadicado,
                          TipoCliente = "05",
                          Direccion_Cliente = cli.Direccion,
                          Telefono_Cliente = cli.Telefono,
                          Id_Cliente = fac.Idcliprv,
                          Ciudad_Cliente = cli.Ciudad,
                          Plazo_De_Pago = cli.Diplazo,
                      };
            return Ok(con);
        }

        //CARTERA POR CLIENTES
        [HttpGet("getCarteraClientes/{cliente}")]
        public ActionResult GetCarteraClientes(string cliente)
        {
            var con = from cli in _context.Set<Cliente>()
                      from vendedor in _context.Set<Maevende>()
                      from fac in _context.Set<FacturasBu>()
                      join subFac in _context.Set<FacturasBu>() on fac.Numefac equals subFac.Numefac into details
                      where fac.Sactfac > 0
                            && cli.Idcliente == fac.Idcliprv
                            && fac.Idcliprv == cliente
                            && vendedor.Idvende == fac.Idvende
                            && details.Max(x => x.IdenFacturasBu) == fac.IdenFacturasBu
                      orderby fac.Numefac ascending
                      select new
                      {
                          Num_Factura = fac.Numefac,
                          Nombre_CLiente = cli.Razoncial,
                          Id_Fecha = (from fac2 in _context.Set<FacturasBu>()
                                      where fac2.Numefac == fac.Numefac
                                      orderby fac2.IdenFacturasBu ascending
                                      select fac2.Fecharadicado).FirstOrDefault(),
                          LAPSO_DOC = fac.Fechfac,
                          Fecha_Vencimiento = fac.Vencfac,
                          Nombre_Vendedor = vendedor.Nombvende,
                          Id_Vendedor = fac.Idvende,
                          Tipo_Movimiento = "FV",
                          Saldo_Cartera = fac.Sactfac,
                          Fecha_Radicado = fac.Fecharadicado,
                          TipoCliente = "05",
                          Direccion_Cliente = cli.Direccion,
                          Telefono_Cliente = cli.Telefono,
                          Id_Cliente = fac.Idcliprv,
                          Ciudad_Cliente = cli.Ciudad,
                          Plazo_De_Pago = cli.Diplazo,
                      };
            return Ok(con);
        }

        // PUT: api/Clientes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCliente(int id, FacturasBu FacturasBu)
        {
            if (id != FacturasBu.IdenFacturasBu)
            {
                return BadRequest();
            }

            _context.Entry(FacturasBu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FacturasBuExists(id))
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

        // POST: api/Clientes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FacturasBu>> PostCliente(FacturasBu FacturasBu)
        {
            if (_context.FacturasBus == null)
            {
                return Problem("Entity set 'ContabilidadContext.FacturasBu'  is null.");
            }
            _context.FacturasBus.Add(FacturasBu);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (FacturasBuExists(FacturasBu.IdenFacturasBu))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetFacturasBu", new { id = FacturasBu.IdenFacturasBu }, FacturasBu);
        }

        // DELETE: api/Clientes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCliente(int id)
        {
            if (_context.FacturasBus == null)
            {
                return NotFound();
            }
            var FacturasBu = await _context.FacturasBus.FindAsync(id);
            if (FacturasBu == null)
            {
                return NotFound();
            }

            _context.FacturasBus.Remove(FacturasBu);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FacturasBuExists(int id)
        {
            return (_context.FacturasBus?.Any(e => e.IdenFacturasBu == id)).GetValueOrDefault();
        }

    }
}
