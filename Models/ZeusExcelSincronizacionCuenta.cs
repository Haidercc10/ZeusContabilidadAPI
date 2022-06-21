using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusExcelSincronizacionCuenta
    {
        public int Id { get; set; }
        public int? UsuarioId { get; set; }
        public string? Cuenta { get; set; }
        public string? Descripcion { get; set; }
        public bool? Sincronizada { get; set; }

        public virtual ZeusExcelSincronizacionUsuario? Usuario { get; set; }
    }
}
