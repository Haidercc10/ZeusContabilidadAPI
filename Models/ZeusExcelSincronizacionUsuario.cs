using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusExcelSincronizacionUsuario
    {
        public ZeusExcelSincronizacionUsuario()
        {
            ZeusExcelSincronizacionCuenta = new HashSet<ZeusExcelSincronizacionCuenta>();
        }

        public int Id { get; set; }
        public string? Usuario { get; set; }
        public DateTime? Fecha { get; set; }

        public virtual ICollection<ZeusExcelSincronizacionCuenta> ZeusExcelSincronizacionCuenta { get; set; }
    }
}
