using DBInventarioZeusAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using System.Text.RegularExpressions;

namespace ContabilidadZeusAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class SaldoProv_LibroPrincipalController : ControllerBase
    {
        private readonly ContabilidadContext _context;

        public SaldoProv_LibroPrincipalController(ContabilidadContext context)
        {
            _context = context;
        }

        // GET: api/SaldoProvLibroPrincipal
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SaldoProvLibroPrincipal>>> GetFacturasBu()
        {
            if (_context.Clientes == null)
            {
                return NotFound();
            }
            return await _context.SaldoProvLibroPrincipals.ToListAsync();
        }

        // GET: api/<SaldoProvLibroPrincipal>
        [HttpGet("getCostosProveedores/{cuenta}")]
        public ActionResult GetCostosProveedores(string cuenta)
        {
            var con = from S in _context.Set<SaldoProvLibroPrincipal>()
                      join P in _context.Set<Proveedore>() on S.Idprove equals P.Idprove
                      where S.Anomescta == (from S2 in _context.Set<SaldoProvLibroPrincipal>()
                                            where S2.Idprove == S.Idprove
                                            select S2.Anomescta).Max() &&
                            S.Codicta == cuenta &&
                            S.Sdaccta != 0
                      group new { S,P } by new
                      {
                          S.Idprove,
                          P.Razoncial,
                          S.Sdaccta,
                          S.Anomescta,
                          S.Codicta
                      } into S
                      select new
                      {
                          S.Key.Idprove,
                          S.Key.Razoncial,
                          S.Key.Sdaccta,
                          S.Key.Anomescta,
                          S.Key.Codicta,
                      };

            return con.Any() ? Ok(con) : BadRequest();
        }

        // GET: api/<SaldoProvLibroPrincipal>
        [HttpGet("getCostosTotalProveedores/{cuenta}")]
        public ActionResult GetCostosTotalProveedores(string cuenta)
        {
            var con = (from S in _context.Set<SaldoProvLibroPrincipal>()
                      join P in _context.Set<Proveedore>() on S.Idprove equals P.Idprove
                      where S.Anomescta == (from S2 in _context.Set<SaldoProvLibroPrincipal>()
                                            where S2.Idprove == S.Idprove
                                            select S2.Anomescta).Max() &&
                            S.Codicta == cuenta &&
                            S.Sdaccta != 0 &&
                            P.Idprove != (900458314).ToString() &&
                            P.Idprove != (900362200).ToString()
                       group new { S, P } by new
                      {
                          S.Idprove,
                          P.Razoncial,
                          S.Sdaccta,
                          S.Anomescta
                      } into S
                      select S.Key.Sdaccta).Sum();

            return Ok(con);
        }
    }
}
