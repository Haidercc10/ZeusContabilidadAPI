using DBInventarioZeusAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContabilidadZeusAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class FacturasLibroPrincipalController : ControllerBase
    {
        private readonly ContabilidadContext _context;

        public FacturasLibroPrincipalController(ContabilidadContext context)
        {
            _context = context;
        }

        // GET: api/Clientes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FacturasLibroPrincipal>>> GetFacturasBu()
        {
            if (_context.Clientes == null)
            {
                return NotFound();
            }
            return await _context.FacturasLibroPrincipals.ToListAsync();
        }

        [HttpGet("getFacturasProveedores/{cuenta}")]
        public ActionResult GetFacturasProveedores(string cuenta)
        {
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
            var con = from F in _context.Set<FacturasLibroPrincipal>()
                      join P in _context.Set<Proveedore>() on F.Idcliprv equals P.Idprove
                      where F.Codicta == cuenta &&
                            F.Anomesfac == (from F2 in _context.Set<FacturasLibroPrincipal>()
                                            where F.Numefac == F2.Numefac
                                            select F2.Anomesfac).Max() &&
                            F.Sactfac != 0
                      orderby P.Idprove ascending, F.Numefac ascending
                      select new
                      {
                          Id_Proveedor = P.Idprove,
                          Proveedor = P.Razoncial,
                          Factura = F.Numefac,
                          Fecha_Factura = F.Fechfac,
                          Fecha_Vencimiento = F.Vencfac,
                          Periodo = F.Anomesfac,
                          Saldo_Actual = F.Sactfac,
                          Mora = 0,
                          Cuenta = F.Codicta,
                      };
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
            return Ok(con);
        }
    }
}
