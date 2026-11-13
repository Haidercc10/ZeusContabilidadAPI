using DBInventarioZeusAPI.Models;
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
        public async Task<ActionResult> GetCartera_Anio_Mes(string anio, string mes)
        {
#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
            var con = await (from f in _context.Set<FacturasBu>().AsNoTracking()
                       join c in _context.Set<Cliente>().AsNoTracking() on f.Idcliprv equals c.Idcliente
                       join v in _context.Set<Maevende>().AsNoTracking() on f.Idvende equals v.Idvende
                       join subFac in _context.Set<FacturasBu>().AsNoTracking() on f.Numefac equals subFac.Numefac into details
                       where f.Sactfac > 0
                             && c.Idcliente == f.Idcliprv
                             && v.Idvende == f.Idvende
                             && details.Max(x => x.IdenFacturasBu) == f.IdenFacturasBu
                             && (from fac2 in _context.Set<FacturasBu>().AsNoTracking()
                                 where fac2.Numefac == f.Numefac
                                 orderby fac2.IdenFacturasBu ascending
                                 select fac2.Fecharadicado).FirstOrDefault().Substring(0, 4) == anio
                             && (from fac2 in _context.Set<FacturasBu>().AsNoTracking()
                                 where fac2.Numefac == f.Numefac
                                 orderby fac2.IdenFacturasBu ascending
                                 select fac2.Fecharadicado).FirstOrDefault().Substring(5, 2) == mes
                       select f.Sactfac).SumAsync();
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
            return con > 0 ? Ok(con) : BadRequest("No hay datos encontrados");
        }

        //CARTERA TOTAL POR FACTURA
        [HttpPost("getCarteraTotal")]
        public async Task<ActionResult> GetCarteraTotal([FromBody] List<string> clientes, string? vendedor = "")
        {
            var hoy = DateTime.Now;

            //El vendedor se toma de la factura (no del cliente) para no perder facturas de clientes reasignados a otro vendedor
            var con = await (from cli in _context.Set<Cliente>().AsNoTracking()
                      join fac in _context.Set<FacturasBu>().AsNoTracking() on cli.Idcliente equals fac.Idcliprv
                      join vende in _context.Set<Maevende>().AsNoTracking() on fac.Idvende equals vende.Idvende
                      where fac.Sactfac > 0
                            && fac.Anomesfac == (from fb in _context.Set<FacturasBu>().AsNoTracking() orderby fb.Anomesfac descending select fb.Anomesfac).FirstOrDefault()
                            && (vendedor != "" ? vende.Nombvende == vendedor : vende.Nombvende.Contains(vendedor))
                            && (clientes.Any() ? clientes.Contains(cli.Idcliente) : cli.Idcliente.Contains(""))
                      orderby fac.Numefac ascending
                      select new
                      {
                          Num_Factura = fac.Numefac,
                          Nombre_CLiente = cli.Razoncial,
                          Id_Fecha = (from fac2 in _context.Set<FacturasBu>().AsNoTracking()
                                      where fac2.Numefac == fac.Numefac
                                      orderby fac2.IdenFacturasBu ascending
                                      select fac2.Fecharadicado).FirstOrDefault(),
                          LAPSO_DOC = fac.Fechfac,
                          Fecha_Vencimiento = fac.Vencfac,
                          Nombre_Vendedor = vende.Nombvende,
                          Id_Vendedor = fac.Idvende,
                          Tipo_Movimiento = "FV",
                          Saldo_Cartera = fac.Sactfac + (from fbu in _context.Set<FacturasBu>().AsNoTracking() where fbu.Anomesfac == fac.Anomesfac && fbu.Sactfac < 0 && fbu.Numefac == fac.Numefac select fbu.Sactfac).Sum(),
                          Fecha_Radicado = fac.Fecharadicado,
                          TipoCliente = "05",
                          Direccion_Cliente = cli.Direccion,
                          Telefono_Cliente = cli.Telefono,
                          Id_Cliente = fac.Idcliprv,
                          Ciudad_Cliente = cli.Ciudad,
                          Plazo_De_Pago = cli.Diplazo,
                          Fecha_Actual = hoy.ToString("yyyy/MM/dd"),
                          Cantidad_Dias = (Convert.ToDateTime(hoy.ToString("yyyy/MM/dd")).Subtract(Convert.ToDateTime(fac.Fechfac))).TotalDays, 
                          SaldoPlazo1 = (Convert.ToDateTime(hoy.ToString("yyyy/MM/dd")) - Convert.ToDateTime(fac.Fechfac)).Days >= 0 && (Convert.ToDateTime(hoy.ToString("yyyy/MM/dd")) - Convert.ToDateTime(fac.Fechfac)).Days <= 30 ? fac.Sactfac + (from fbu in _context.Set<FacturasBu>() where fbu.Anomesfac == fac.Anomesfac && fbu.Sactfac < 0 && fbu.Numefac == fac.Numefac select fbu.Sactfac).Sum() : -1,
                          SaldoPlazo2 = (Convert.ToDateTime(hoy.ToString("yyyy/MM/dd")) - Convert.ToDateTime(fac.Fechfac)).Days >= 31 && (Convert.ToDateTime(hoy.ToString("yyyy/MM/dd")) - Convert.ToDateTime(fac.Fechfac)).Days <= 60 ? fac.Sactfac + (from fbu in _context.Set<FacturasBu>() where fbu.Anomesfac == fac.Anomesfac && fbu.Sactfac < 0 && fbu.Numefac == fac.Numefac select fbu.Sactfac).Sum() : -1,
                          SaldoPlazo3 = (Convert.ToDateTime(hoy.ToString("yyyy/MM/dd")) - Convert.ToDateTime(fac.Fechfac)).Days >= 61 && (Convert.ToDateTime(hoy.ToString("yyyy/MM/dd")) - Convert.ToDateTime(fac.Fechfac)).Days <= 90 ? fac.Sactfac + (from fbu in _context.Set<FacturasBu>() where fbu.Anomesfac == fac.Anomesfac && fbu.Sactfac < 0 && fbu.Numefac == fac.Numefac select fbu.Sactfac).Sum() : -1,
                          SaldoPlazo4 = (Convert.ToDateTime(hoy.ToString("yyyy/MM/dd")) - Convert.ToDateTime(fac.Fechfac)).Days >= 91 && (Convert.ToDateTime(hoy.ToString("yyyy/MM/dd")) - Convert.ToDateTime(fac.Fechfac)).Days <= 120 ? fac.Sactfac + (from fbu in _context.Set<FacturasBu>() where fbu.Anomesfac == fac.Anomesfac && fbu.Sactfac < 0 && fbu.Numefac == fac.Numefac select fbu.Sactfac).Sum() : -1,
                          SaldoPlazo5 = (Convert.ToDateTime(hoy.ToString("yyyy/MM/dd")) - Convert.ToDateTime(fac.Fechfac)).Days > 120 ? fac.Sactfac + (from fbu in _context.Set<FacturasBu>() where fbu.Anomesfac == fac.Anomesfac && fbu.Sactfac < 0 && fbu.Numefac == fac.Numefac select fbu.Sactfac).Sum() : -1
                      }).ToListAsync();
            return Ok(con);
        }

        //CARTERA POR VENDEDOR
        [HttpGet("getCarteraVendedor/{id}")]
        public async Task<ActionResult> GetCarteraVendedor(string id)
        {
            var con = await (from cli in _context.Set<Cliente>().AsNoTracking()
                      join fac in _context.Set<FacturasBu>().AsNoTracking() on cli.Idcliente equals fac.Idcliprv
                      join vendedor in _context.Set<Maevende>().AsNoTracking() on fac.Idvende equals vendedor.Idvende
                      where fac.Sactfac > 0
                            && fac.Idvende == id
                            && fac.Anomesfac == (from fb in _context.Set<FacturasBu>().AsNoTracking() orderby fb.Anomesfac descending select fb.Anomesfac).FirstOrDefault()
                      orderby fac.Numefac ascending
                      select new
                      {
                          Num_Factura = fac.Numefac,
                          Nombre_CLiente = cli.Razoncial,
                          Id_Fecha = (from fac2 in _context.Set<FacturasBu>().AsNoTracking()
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
                      }).ToListAsync();
            return Ok(con);
        }

        //CARTERA POR CLIENTES
        [HttpGet("getCarteraClientes/{cliente}")]
        public async Task<ActionResult> GetCarteraClientes(string cliente)
        {
            var con = await (from cli in _context.Set<Cliente>().AsNoTracking()
                      join fac in _context.Set<FacturasBu>().AsNoTracking() on cli.Idcliente equals fac.Idcliprv
                      join vendedor in _context.Set<Maevende>().AsNoTracking() on fac.Idvende equals vendedor.Idvende
                      where fac.Sactfac > 0
                            && fac.Idcliprv == cliente
                            && fac.Anomesfac == (from fb in _context.Set<FacturasBu>().AsNoTracking() orderby fb.Anomesfac descending select fb.Anomesfac).FirstOrDefault()
                      orderby fac.Numefac ascending
                      select new
                      {
                          Num_Factura = fac.Numefac,
                          Nombre_CLiente = cli.Razoncial,
                          Id_Fecha = (from fac2 in _context.Set<FacturasBu>().AsNoTracking()
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
                      }).ToListAsync();
            return Ok(con);
        }

        [HttpGet("getCarteraClientes2/{cliente}")]
        public async Task<ActionResult> GetCarteraClientes2(string cliente)
        {
            var ultimoPeriodo = await _context.Set<FacturasBu>()
                .MaxAsync(x => x.Anomesfac);

            var cartera = await (
                from cli in _context.Set<Cliente>()
                join fac in _context.Set<FacturasBu>() on cli.Idcliente equals fac.Idcliprv
                join vendedor in _context.Set<Maevende>() on fac.Idvende equals vendedor.Idvende
                where fac.Sactfac > 0
                      && fac.Idcliprv == cliente
                      && fac.Anomesfac == ultimoPeriodo
                orderby fac.Numefac ascending
                select new
                {
                    Num_Factura = fac.Numefac,
                    Nombre_CLiente = cli.Razoncial,
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
                }
            ).ToListAsync();

            return Ok(cartera);
        }

        //CARTERA POR AGRUPADA POR CLIENTES
        [HttpPost("getCarteraAgrupadaClientes")]
        public async Task<ActionResult> GetCarteraAgrupadaClientes([FromBody] List<string> clientes, string? vendedor = "")
        {
            var con = await (from f in _context.Set<FacturasBu>().AsNoTracking()
                      join c in _context.Set<Cliente>().AsNoTracking() on f.Idcliprv equals c.Idcliente
                      join v in _context.Set<Maevende>().AsNoTracking() on f.Idvende equals v.Idvende
                      where f.Sactfac > 0
                            && f.Anomesfac == (from fb in _context.Set<FacturasBu>().AsNoTracking() orderby fb.Anomesfac descending select fb.Anomesfac).FirstOrDefault()
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
                      }).ToListAsync();
            return Ok(con);
        }

        //CARTERA POR AGRUPADA POR VENDEDORES
        [HttpGet("getCarteraAgrupadaVendedores")]
        public async Task<ActionResult> GetCarteraAgrupadaVendedores(string? vendedor = "")
        {
            var con = await (from f in _context.Set<FacturasBu>().AsNoTracking()
                      join v in _context.Set<Maevende>().AsNoTracking() on f.Idvende equals v.Idvende
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
                      }).ToListAsync();
            return Ok(con);
        }

        // CARTERA MES A MES, AÑO A AÑO
        [HttpGet("getCartera_Mes_Anio/{periodo}")]
        public async Task<ActionResult> GetCartera_Mes_Anio(string periodo)
        {
#pragma warning disable CS8604 // Posible argumento de referencia nulo
            var datos = new List<object>();
            for (int i = 0; i < 12; i++)
            {
                string mes = (i + 1).ToString().Length > 1 ? $"{i + 1}" : $"0{i + 1}";
                var con = await (from f in _context.Set<FacturasBu>().AsNoTracking()
                           where f.Sactfac > 0 &&
                                 f.Idvende != "" &&
                                 f.Anomesfac == $"{periodo}{mes}" &&
                                 f.IdenFacturasBu == (from f2 in _context.Set<FacturasBu>().AsNoTracking()
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
                           }).FirstOrDefaultAsync();
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

        //==================== VERSIONES OPTIMIZADAS DE CARTERA (Dashboard Recaudos) ====================
        // Copias de getCarteraTotal, getCarteraAgrupadaClientes y getCarteraAgrupadaVendedores que devuelven
        // la misma información, pero:
        //  - Calculan el último periodo (Anomesfac) una sola vez, en vez de una subconsulta dentro del WHERE.
        //  - Eliminan las subconsultas correlacionadas por fila (Id_Fecha, Saldo_Cartera y SaldoPlazo1..5),
        //    reemplazándolas por consultas agrupadas que se ejecutan una sola vez.
        //  - Calculan días y plazos en memoria (Fechfac es texto y no se puede operar en SQL).
        //  - Solo aplican los filtros de vendedor / clientes cuando vienen informados (sin LIKE '%%').

        //Función que devuelve el último periodo (AAAAMM) registrado en FACTURAS_BU
        private async Task<string?> ObtenerUltimoPeriodoCartera() =>
            await _context.Set<FacturasBu>().AsNoTracking().MaxAsync(x => x.Anomesfac);

        //CARTERA TOTAL POR FACTURA (OPTIMIZADA)
        [HttpPost("getCarteraTotal2")]
        public async Task<ActionResult> GetCarteraTotal2([FromBody] List<string>? clientes, string? vendedor = "")
        {
            clientes ??= new List<string>();
            var hoy = DateTime.Now;
            var fechaHoy = hoy.Date;
            var ultimoPeriodo = await ObtenerUltimoPeriodoCartera();

            //Facturas con saldo del último periodo (misma lógica de joins que getCarteraTotal).
            //El vendedor se toma de la factura (no del cliente) para no perder facturas de clientes reasignados a otro vendedor
            var facturasQuery = from cli in _context.Set<Cliente>().AsNoTracking()
                                join fac in _context.Set<FacturasBu>().AsNoTracking() on cli.Idcliente equals fac.Idcliprv
                                join vende in _context.Set<Maevende>().AsNoTracking() on fac.Idvende equals vende.Idvende
                                where fac.Sactfac > 0
                                      && fac.Anomesfac == ultimoPeriodo
                                select new { cli, vende, fac };

            if (!string.IsNullOrEmpty(vendedor)) facturasQuery = facturasQuery.Where(x => x.vende.Nombvende == vendedor);
            if (clientes.Any()) facturasQuery = facturasQuery.Where(x => clientes.Contains(x.cli.Idcliente));

            var facturas = await facturasQuery
                .OrderBy(x => x.fac.Numefac)
                .Select(x => new
                {
                    x.fac.Numefac,
                    x.cli.Razoncial,
                    x.fac.Fechfac,
                    x.fac.Vencfac,
                    x.vende.Nombvende,
                    x.fac.Idvende,
                    x.fac.Sactfac,
                    x.fac.Fecharadicado,
                    x.cli.Direccion,
                    x.cli.Telefono,
                    x.fac.Idcliprv,
                    x.cli.Ciudad,
                    x.cli.Diplazo,
                }).ToListAsync();

            if (!facturas.Any()) return Ok(facturas);

            //Abonos (saldos negativos) del último periodo agrupados por factura: una sola consulta en vez de 6 subconsultas por fila
            var abonos = await _context.Set<FacturasBu>().AsNoTracking()
                .Where(x => x.Anomesfac == ultimoPeriodo && x.Sactfac < 0)
                .GroupBy(x => x.Numefac)
                .Select(g => new { Numefac = g.Key, Total = g.Sum(x => x.Sactfac) })
                .ToDictionaryAsync(x => x.Numefac, x => x.Total);

            //Primera fecha de radicado de cada factura (su registro más antiguo en el historial).
            //Se hace en una sola consulta filtrando con la misma consulta de facturas (IN subconsulta), en vez de una búsqueda por fila.
            var numerosFactura = facturasQuery.Select(x => x.fac.Numefac);
            var historial = await _context.Set<FacturasBu>().AsNoTracking()
                .Where(h => numerosFactura.Contains(h.Numefac))
                .Select(h => new { h.Numefac, h.IdenFacturasBu, h.Fecharadicado })
                .ToListAsync();
            var primeraFechaRadicado = historial
                .GroupBy(h => h.Numefac)
                .ToDictionary(g => g.Key, g => g.OrderBy(h => h.IdenFacturasBu).First().Fecharadicado);

            var fechaActual = hoy.ToString("yyyy/MM/dd");
            var resultado = facturas.Select(f =>
            {
                var saldo = f.Sactfac + (abonos.TryGetValue(f.Numefac, out var abono) ? abono : 0);
                var fechaFactura = DateTime.TryParse(f.Fechfac, out var fecha) ? fecha : DateTime.MinValue;
                var diferencia = fechaHoy - fechaFactura;
                var dias = diferencia.Days;

                return new
                {
                    Num_Factura = f.Numefac,
                    Nombre_CLiente = f.Razoncial,
                    Id_Fecha = primeraFechaRadicado.GetValueOrDefault(f.Numefac),
                    LAPSO_DOC = f.Fechfac,
                    Fecha_Vencimiento = f.Vencfac,
                    Nombre_Vendedor = f.Nombvende,
                    Id_Vendedor = f.Idvende,
                    Tipo_Movimiento = "FV",
                    Saldo_Cartera = saldo,
                    Fecha_Radicado = f.Fecharadicado,
                    TipoCliente = "05",
                    Direccion_Cliente = f.Direccion,
                    Telefono_Cliente = f.Telefono,
                    Id_Cliente = f.Idcliprv,
                    Ciudad_Cliente = f.Ciudad,
                    Plazo_De_Pago = f.Diplazo,
                    Fecha_Actual = fechaActual,
                    Cantidad_Dias = diferencia.TotalDays,
                    SaldoPlazo1 = dias >= 0 && dias <= 30 ? saldo : -1,
                    SaldoPlazo2 = dias >= 31 && dias <= 60 ? saldo : -1,
                    SaldoPlazo3 = dias >= 61 && dias <= 90 ? saldo : -1,
                    SaldoPlazo4 = dias >= 91 && dias <= 120 ? saldo : -1,
                    SaldoPlazo5 = dias > 120 ? saldo : -1,
                };
            }).ToList();

            return Ok(resultado);
        }

        //CARTERA AGRUPADA POR CLIENTES (OPTIMIZADA)
        [HttpPost("getCarteraAgrupadaClientes2")]
        public async Task<ActionResult> GetCarteraAgrupadaClientes2([FromBody] List<string>? clientes, string? vendedor = "")
        {
            clientes ??= new List<string>();
            var ultimoPeriodo = await ObtenerUltimoPeriodoCartera();

            var query = from f in _context.Set<FacturasBu>().AsNoTracking()
                        join c in _context.Set<Cliente>().AsNoTracking() on f.Idcliprv equals c.Idcliente
                        join v in _context.Set<Maevende>().AsNoTracking() on f.Idvende equals v.Idvende
                        where f.Sactfac > 0 && f.Anomesfac == ultimoPeriodo
                        select new { f, c, v };

            if (!string.IsNullOrEmpty(vendedor)) query = query.Where(x => x.v.Nombvende == vendedor);
            if (clientes.Any()) query = query.Where(x => clientes.Contains(x.c.Idcliente));

            var con = await query
                .GroupBy(x => new { x.c.Idcliente, x.c.Razoncial, x.v.Nombvende, x.f.Idvende })
                .Select(g => new
                {
                    g.Key.Idcliente,
                    g.Key.Razoncial,
                    g.Key.Nombvende,
                    g.Key.Idvende,
                    SubTotal = g.Sum(x => x.f.Sactfac)
                }).ToListAsync();
            return Ok(con);
        }

        //CARTERA AGRUPADA POR VENDEDORES (OPTIMIZADA)
        [HttpGet("getCarteraAgrupadaVendedores2")]
        public async Task<ActionResult> GetCarteraAgrupadaVendedores2(string? vendedor = "")
        {
            var ultimoPeriodo = await ObtenerUltimoPeriodoCartera();

            var query = from f in _context.Set<FacturasBu>().AsNoTracking()
                        join v in _context.Set<Maevende>().AsNoTracking() on f.Idvende equals v.Idvende
                        where f.Sactfac > 0 && f.Anomesfac == ultimoPeriodo
                        select new { f, v };

            if (!string.IsNullOrEmpty(vendedor)) query = query.Where(x => x.v.Nombvende == vendedor);

            var con = await query
                .GroupBy(x => new { x.v.Nombvende, x.v.Idvende })
                .Select(g => new
                {
                    g.Key.Nombvende,
                    g.Key.Idvende,
                    SubTotal = g.Sum(x => x.f.Sactfac)
                }).ToListAsync();
            return Ok(con);
        }

        // CARTERA MES A MES, AÑO A AÑO (OPTIMIZADA)
        // Copia de getCartera_Mes_Anio: en vez de 12 consultas secuenciales (una por mes) con una subconsulta MAX por fila,
        // hace una sola consulta para los 12 periodos del año. Devuelve el mismo arreglo de 12 posiciones (null si el mes no tiene datos).
        [HttpGet("getCartera_Mes_Anio2/{periodo}")]
        public async Task<ActionResult> GetCartera_Mes_Anio2(string periodo)
        {
            var meses = Enumerable.Range(1, 12).Select(m => m.ToString("00")).ToList();
            var periodos = meses.Select(m => $"{periodo}{m}").ToList();

            //Último registro (mayor IdenFacturasBu) de cada factura dentro de cada mes
            var ultimosRegistros = _context.Set<FacturasBu>().AsNoTracking()
                .Where(f2 => periodos.Contains(f2.Anomesfac))
                .GroupBy(f2 => new { f2.Anomesfac, f2.Numefac })
                .Select(g => g.Max(x => x.IdenFacturasBu));

            var totales = await _context.Set<FacturasBu>().AsNoTracking()
                .Where(f => periodos.Contains(f.Anomesfac)
                            && f.Sactfac > 0
                            && f.Idvende != ""
                            && ultimosRegistros.Contains(f.IdenFacturasBu))
                .GroupBy(f => f.Anomesfac)
                .Select(g => new { Anomesfac = g.Key, Valor = g.Sum(x => x.Sactfac) })
                .ToDictionaryAsync(x => x.Anomesfac, x => x.Valor);

            var datos = meses.Select(mes => totales.TryGetValue($"{periodo}{mes}", out var valor)
                ? (object)new { Anomesfac = $"{periodo}{mes}", Mes = mes, Valor = valor }
                : null).ToList();

            return Ok(datos);
        }

    }
}