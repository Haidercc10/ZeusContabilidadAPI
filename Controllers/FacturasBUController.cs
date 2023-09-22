using DBInventarioZeusAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        // CARTERA TOTAL
        [HttpGet("getCartera")]
        public ActionResult GetCartera(string? vendedor = "", string? cliente = "")
        {
            var con = (from f in _context.Set<FacturasBu>()
                       join c in _context.Set<Cliente>() on f.Idcliprv equals c.Idcliente
                       join v in _context.Set<Maevende>() on f.Idvende equals v.Idvende
                       join subFac in _context.Set<FacturasBu>() on f.Numefac equals subFac.Numefac into details
                       where f.Sactfac > 0
                             && details.Max(x => x.IdenFacturasBu) == f.IdenFacturasBu
                             && (vendedor != "" ? v.Nombvende == vendedor : v.Nombvende.Contains(vendedor))
                             && (cliente != "" ? c.Razoncial == cliente : c.Razoncial.Contains(cliente))
                       select f.Sactfac).Sum();
            return con > 0 ? Ok(con) : BadRequest("No hay datos encontrados");
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
        [HttpGet("getCarteraTotal")]
        public ActionResult GetCarteraTotal(string? vendedor = "", string? cliente = "")
        {
            var con = from cli in _context.Set<Cliente>()
                      from vende in _context.Set<Maevende>()
                      from fac in _context.Set<FacturasBu>()
                      join subFac in _context.Set<FacturasBu>() on fac.Numefac equals subFac.Numefac into details
                      where fac.Sactfac > 0
                            && cli.Idcliente == fac.Idcliprv
                            && vende.Idvende == fac.Idvende
                            && details.Max(x => x.IdenFacturasBu) == fac.IdenFacturasBu
                            && (vendedor != "" ? vende.Nombvende == vendedor : vende.Nombvende.Contains(vendedor))
                            && (cliente != "" ? cli.Razoncial == cliente : cli.Razoncial.Contains(cliente))
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
                      join fac in _context.Set<FacturasBu>() on cli.Idcliente equals fac.Idcliprv
                      join vendedor in _context.Set<Maevende>() on fac.Idvende equals vendedor.Idvende
                      join subFac in _context.Set<FacturasBu>() on fac.Numefac equals subFac.Numefac into details
                      where fac.Sactfac > 0
                            && fac.Idcliprv == cliente
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
        [HttpGet("getCarteraAgrupadaClientes")]
        public ActionResult GetCarteraAgrupadaClientes(string? vendedor = "", string? cliente = "")
        {
            var con = from f in _context.Set<FacturasBu>()
                      join c in _context.Set<Cliente>() on f.Idcliprv equals c.Idcliente
                      join v in _context.Set<Maevende>() on f.Idvende equals v.Idvende
                      join subFac in _context.Set<FacturasBu>() on f.Numefac equals subFac.Numefac into details
                      where f.Sactfac > 0
                            && details.Max(x => x.IdenFacturasBu) == f.IdenFacturasBu
                            && (vendedor != "" ? v.Nombvende == vendedor : v.Nombvende.Contains(vendedor))
                            && (cliente != "" ? c.Razoncial == cliente : c.Razoncial.Contains(cliente))
                      group new { f, c, v } by new
                      {
                          c.Idcliente,
                          c.Razoncial,
                          v.Nombvende,
                          f.Idvende
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
                      join subFac in _context.Set<FacturasBu>() on f.Numefac equals subFac.Numefac into details
                      where f.Sactfac > 0
                            && details.Max(x => x.IdenFacturasBu) == f.IdenFacturasBu
                            && (vendedor != "" ? v.Nombvende == vendedor : v.Nombvende.Contains(vendedor))
                      group new { f, v } by new
                      {
                          v.Nombvende,
                          v.Idvende
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