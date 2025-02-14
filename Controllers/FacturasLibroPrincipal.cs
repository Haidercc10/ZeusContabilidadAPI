﻿using DBInventarioZeusAPI.Models;
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

        [HttpGet("getFacturasProveedores2/{cuenta}")]
        public ActionResult GetFacturasProveedores2(string cuenta)
        {
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
            var cuentas = new List<string>();
            cuentas.Add("220505");
            cuentas.Add("220510");
            var con = from F in _context.Set<FacturasLibroPrincipal>()
                      join P in _context.Set<Proveedore>() on F.Idcliprv equals P.Idprove
                      where cuentas.Contains(F.Codicta) &&
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

        [HttpGet("getFacturasProveedores/{cuenta}")]
        public ActionResult GetFacturasProveedores(string cuenta)
        {
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
            var cuentas = new List<string>();
            cuentas.Add("220505");
            cuentas.Add("220510");
            var con = from F in _context.Set<FacturasLibroPrincipal>()
                      join P in _context.Set<Proveedore>() on F.Idcliprv equals P.Idprove
                      group new {F, P} by new
                      {
                          P.Idprove,
                          P.Razoncial,
                          F.Numefac,
                          F.Anomesfac,
                          F.Codicta,
                      } into F
                      where cuentas.Contains(F.Key.Codicta) &&
                            F.Key.Anomesfac == (from F2 in _context.Set<FacturasLibroPrincipal>()
                                                where F.Key.Numefac == F2.Numefac
                                                select F2.Anomesfac).Max() &&
                            F.Sum(x => x.F.Sactfac) != 0
                      orderby F.Key.Idprove ascending, F.Key.Numefac ascending
                      select new
                      {
                          Id_Proveedor = F.Key.Idprove,
                          Proveedor = F.Key.Razoncial,
                          Factura = F.Key.Numefac,
                          Fecha_Factura = (from F2 in _context.Set<FacturasLibroPrincipal>()
                                           where F.Key.Numefac == F2.Numefac
                                           select F2.Fechfac).Max(),
                          Fecha_Vencimiento = (from F2 in _context.Set<FacturasLibroPrincipal>()
                                               where F.Key.Numefac == F2.Numefac
                                               select F2.Vencfac).Max(),
                          Periodo = F.Key.Anomesfac,
                          Saldo_Actual = F.Sum(x => x.F.Sactfac),
                          Mora = 0,
                          Cuenta = F.Key.Codicta,
                      };
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
            return Ok(con);
        }

        //Consulta que devolverá la información de lo que se debia a proveedores en cada uno de los meses del año
        [HttpGet("getCostosProveedores_Mes_Mes/{anio}/{cuenta}")]
        public ActionResult GetCostosProveedores_Mes_Mes(string anio, string cuenta)
        {
            var cuentas = new List<string>();
            cuentas.Add("220505");
            cuentas.Add("220510");
            var invergoal = from F in _context.Set<FacturasBuLibroPrincipal>()
                            where cuentas.Contains(F.Codicta) &&
                                  F.Anomesfac.Contains(anio) && 
                                  F.Idcliprv == "900362200"
                            group F by new { F.Anomesfac }
                            into F
                            select new
                            {
                                Periodo = F.Key.Anomesfac,
                                Costo = F.Sum(x => x.Sactfac),
                                Empresa = "Invergoal SAS"
                            };

            var inversuez = from F in _context.Set<FacturasBuLibroPrincipal>()
                            where cuentas.Contains(F.Codicta) &&
                                  F.Anomesfac.Contains(anio) &&
                                  F.Idcliprv == "900458314"
                            group F by new { F.Anomesfac }
                            into F
                            select new
                            {
                                Periodo = F.Key.Anomesfac,
                                Costo = F.Sum(x => x.Sactfac),
                                Empresa = "Inversuez SAS"
                            };

            var plasticaribe = from F in _context.Set<FacturasBuLibroPrincipal>()
                               where cuentas.Contains(F.Codicta) &&
                                     F.Anomesfac.Contains(anio) &&
                                     F.Idcliprv != "900458314" &&
                                     F.Idcliprv != "900362200"
                               group F by new { F.Anomesfac }
                               into F
                               select new
                               {
                                   Periodo = F.Key.Anomesfac,
                                   Costo = F.Sum(x => x.Sactfac),
                                   Empresa = "Plasticaribe SAS"
                               };
            return Ok(plasticaribe.Concat(invergoal).Concat(inversuez));
        }
    }
}