using DBInventarioZeusAPI.Models;
using Intercom.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using static Grpc.Core.Metadata;

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

        // CARTERA POR AÑO Y MES
        [HttpGet("getCartera_Anio_Mes/{anio}/{mes}")]
        public ActionResult GetCartera_Anio_Mes(string anio, string mes)
        {
#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
            var con = (from f in _context.Set<FacturasBu>()
                       from c in _context.Set<Cliente>()
                       from v in _context.Set<Maevende>()
                       join subFac in _context.Set<FacturasBu>() on f.Numefac equals subFac.Numefac into details
                       where f.Sactfac > 0
                             && c.Idcliente == f.Idcliprv
                             && v.Idvende == f.Idvende
                             && details.Max(x => x.IdenFacturasBu) == f.IdenFacturasBu
                             && (from fac2 in _context.Set<FacturasBu>()
                                 where fac2.Numefac == f.Numefac
                                 orderby fac2.IdenFacturasBu ascending
                                 select fac2.Fecharadicado).FirstOrDefault().Substring(0, 4) == anio
                             && (from fac2 in _context.Set<FacturasBu>()
                                 where fac2.Numefac == f.Numefac
                                 orderby fac2.IdenFacturasBu ascending
                                 select fac2.Fecharadicado).FirstOrDefault().Substring(5, 2) == mes
                       select f.Sactfac).Sum();
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
            return con > 0 ? Ok(con) : BadRequest("No hay datos encontrados");
        }

        //CARTERA TOTAL POR FACTURA
        [HttpPost("getCarteraTotal")]
        public ActionResult GetCarteraTotal([FromBody] List<string> clientes, string? vendedor = "")
        {
            var hoy = DateTime.Now;

            var con = from cli in _context.Set<Cliente>()
                      from vende in _context.Set<Maevende>()
                      from fac in _context.Set<FacturasBu>()
                      where fac.Sactfac > 0
                            && cli.Idcliente == fac.Idcliprv
                            && vende.Idvende == fac.Idvende
                            && fac.Anomesfac == (from fb in _context.Set<FacturasBu>() orderby fb.Anomesfac descending select fb.Anomesfac).FirstOrDefault()
                            && (vendedor != "" ? vende.Nombvende == vendedor : vende.Nombvende.Contains(vendedor))
                            && (clientes.Any() ? clientes.Contains(cli.Idcliente) : cli.Idcliente.Contains(""))
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
                          Nombre_Vendedor = vende.Nombvende,
                          Id_Vendedor = fac.Idvende,
                          Tipo_Movimiento = "FV",
                          Saldo_Cartera = fac.Sactfac + (from fbu in _context.Set<FacturasBu>() where fbu.Anomesfac == fac.Anomesfac && fbu.Sactfac < 0 && fbu.Numefac == fac.Numefac select fbu.Sactfac == null ? 0 : fbu.Sactfac).Sum(),
                          Fecha_Radicado = fac.Fecharadicado,
                          TipoCliente = "05",
                          Direccion_Cliente = cli.Direccion,
                          Telefono_Cliente = cli.Telefono,
                          Id_Cliente = fac.Idcliprv,
                          Ciudad_Cliente = cli.Ciudad,
                          Plazo_De_Pago = cli.Diplazo,
                          Fecha_Actual = hoy.ToString("yyyy/MM/dd"),
                          Cantidad_Dias = (Convert.ToDateTime(hoy.ToString("yyyy/MM/dd")).Subtract(Convert.ToDateTime(fac.Fechfac))).TotalDays, 
                          SaldoPlazo1 = (Convert.ToDateTime(hoy.ToString("yyyy/MM/dd")) - Convert.ToDateTime(fac.Fechfac)).Days >= 0 && (Convert.ToDateTime(hoy.ToString("yyyy/MM/dd")) - Convert.ToDateTime(fac.Fechfac)).Days <= 30 ? fac.Sactfac + (from fbu in _context.Set<FacturasBu>() where fbu.Anomesfac == fac.Anomesfac && fbu.Sactfac < 0 && fbu.Numefac == fac.Numefac select fbu.Sactfac == null ? 0 : fbu.Sactfac).Sum() : -1,
                          SaldoPlazo2 = (Convert.ToDateTime(hoy.ToString("yyyy/MM/dd")) - Convert.ToDateTime(fac.Fechfac)).Days >= 31 && (Convert.ToDateTime(hoy.ToString("yyyy/MM/dd")) - Convert.ToDateTime(fac.Fechfac)).Days <= 60 ? fac.Sactfac + (from fbu in _context.Set<FacturasBu>() where fbu.Anomesfac == fac.Anomesfac && fbu.Sactfac < 0 && fbu.Numefac == fac.Numefac select fbu.Sactfac == null ? 0 : fbu.Sactfac).Sum() : -1,
                          SaldoPlazo3 = (Convert.ToDateTime(hoy.ToString("yyyy/MM/dd")) - Convert.ToDateTime(fac.Fechfac)).Days >= 61 && (Convert.ToDateTime(hoy.ToString("yyyy/MM/dd")) - Convert.ToDateTime(fac.Fechfac)).Days <= 90 ? fac.Sactfac + (from fbu in _context.Set<FacturasBu>() where fbu.Anomesfac == fac.Anomesfac && fbu.Sactfac < 0 && fbu.Numefac == fac.Numefac select fbu.Sactfac == null ? 0 : fbu.Sactfac).Sum() : -1,
                          SaldoPlazo4 = (Convert.ToDateTime(hoy.ToString("yyyy/MM/dd")) - Convert.ToDateTime(fac.Fechfac)).Days >= 91 && (Convert.ToDateTime(hoy.ToString("yyyy/MM/dd")) - Convert.ToDateTime(fac.Fechfac)).Days <= 120 ? fac.Sactfac + (from fbu in _context.Set<FacturasBu>() where fbu.Anomesfac == fac.Anomesfac && fbu.Sactfac < 0 && fbu.Numefac == fac.Numefac select fbu.Sactfac == null ? 0 : fbu.Sactfac).Sum() : -1,
                          SaldoPlazo5 = (Convert.ToDateTime(hoy.ToString("yyyy/MM/dd")) - Convert.ToDateTime(fac.Fechfac)).Days > 120 ? fac.Sactfac + (from fbu in _context.Set<FacturasBu>() where fbu.Anomesfac == fac.Anomesfac && fbu.Sactfac < 0 && fbu.Numefac == fac.Numefac select fbu.Sactfac == null ? 0 : fbu.Sactfac).Sum() : -1
                      };
            return Ok(con);
        }

        //CARTERA POR VENDEDOR
        [HttpGet("getCarteraVendedor/{id}")]
        public ActionResult GetCarteraVendedor(string id)
        {
            var con = from cli in _context.Set<Cliente>()
                      join fac in _context.Set<FacturasBu>() on cli.Idcliente equals fac.Idcliprv
                      join vendedor in _context.Set<Maevende>() on fac.Idvende equals vendedor.Idvende
                      where fac.Sactfac > 0
                            && fac.Idvende == id
                            && fac.Anomesfac == (from fb in _context.Set<FacturasBu>() orderby fb.Anomesfac descending select fb.Anomesfac).FirstOrDefault()
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
                      join fac in _context.Set<FacturasBu>() on cli.Idcliente equals fac.Idcliprv
                      join vendedor in _context.Set<Maevende>() on fac.Idvende equals vendedor.Idvende
                      where fac.Sactfac > 0
                            && fac.Idcliprv == cliente
                            && fac.Anomesfac == (from fb in _context.Set<FacturasBu>() orderby fb.Anomesfac descending select fb.Anomesfac).FirstOrDefault()
                      orderby fac.Numefac ascending
                      select new
                      {
                          Num_Factura = fac.Numefac,
                          Nombre_CLiente = cli.Razoncial,
                          Id_Fecha = (from fac2 in _context.Set<FacturasBu>()
                                      where fac2.Numefac == fac.Numefac
                                      orderby fac2.IdenFacturasBu ascending
                                      select fac2.Fecharadicado).FirstOrDefault(),
                          LAPSO_DOC = Convert.ToDateTime(fac.Fechfac),
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

        //CARTERA POR AGRUPADA POR CLIENTES
        [HttpPost("getCarteraAgrupadaClientes")]
        public ActionResult GetCarteraAgrupadaClientes([FromBody] List<string> clientes, string? vendedor = "")
        {
            var con = from f in _context.Set<FacturasBu>()
                      join c in _context.Set<Cliente>() on f.Idcliprv equals c.Idcliente
                      join v in _context.Set<Maevende>() on f.Idvende equals v.Idvende
                      where f.Sactfac > 0
                            && f.Anomesfac == (from fb in _context.Set<FacturasBu>() orderby fb.Anomesfac descending select fb.Anomesfac).FirstOrDefault()
                            && (vendedor != "" ? v.Nombvende == vendedor : v.Nombvende.Contains(vendedor))
                            && (clientes.Any() ? clientes.Contains(c.Idcliente) : c.Idcliente.Contains(""))
                      group new { f, c, v } by new
                      {
                          c.Idcliente,
                          c.Razoncial,
                          v.Nombvende,
                          f.Idvende, 
                          f.Anomesfac
                      } into f
                      select new
                      {
                          f.Key.Idcliente,
                          f.Key.Razoncial,
                          f.Key.Nombvende,
                          f.Key.Idvende,
                          SubTotal = f.Sum(x => x.f.Sactfac)
                      };
            return Ok(con);
        }

        //CARTERA POR AGRUPADA POR VENDEDORES
        [HttpGet("getCarteraAgrupadaVendedores")]
        public ActionResult GetCarteraAgrupadaVendedores(string? vendedor = "")
        {
            var con = from f in _context.Set<FacturasBu>()
                      join v in _context.Set<Maevende>() on f.Idvende equals v.Idvende
                      where f.Sactfac > 0
                            && f.Anomesfac == (from fb in _context.Set<FacturasBu>() orderby fb.Anomesfac descending select fb.Anomesfac).FirstOrDefault()
                            && (vendedor != "" ? v.Nombvende == vendedor : v.Nombvende.Contains(vendedor))
                      group new { f, v } by new
                      {
                          v.Nombvende,
                          v.Idvende, 
                          f.Anomesfac
                      } into f
                      select new
                      {
                          f.Key.Nombvende,
                          f.Key.Idvende,
                          SubTotal = f.Sum(x => x.f.Sactfac)
                      };
            return Ok(con);
        }

        // CARTERA MES A MES, AÑO A AÑO
        [HttpGet("getCartera_Mes_Anio/{periodo}")]
        public ActionResult GetCartera_Mes_Anio(string periodo)
        {
#pragma warning disable CS8604 // Posible argumento de referencia nulo
            var datos = new List<object>();
            for (int i = 0; i < 12; i++)
            {
                string mes = (i + 1).ToString().Length > 1 ? $"{i + 1}" : $"0{i + 1}";
                var con = (from f in _context.Set<FacturasBu>()
                           where f.Sactfac > 0 &&
                                 f.Idvende != "" &&
                                 f.Anomesfac == $"{periodo}{mes}" &&
                                 f.IdenFacturasBu == (from f2 in _context.Set<FacturasBu>()
                                                      where f2.Numefac == f.Numefac &&
                                                            f2.Anomesfac == $"{periodo}{mes}"
                                                      select f2.IdenFacturasBu).Max()
                           group f by new { f.Anomesfac }
                          into f
                           select new
                           {
                               f.Key.Anomesfac,
                               Mes = mes,
                               Valor = f.Sum(x => x.Sactfac)
                           }).FirstOrDefault();
                datos.Add(con);
                if (i == 11) return Ok(datos);
            }
            return Ok(datos);
#pragma warning restore CS8604 // Posible argumento de referencia nulo
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