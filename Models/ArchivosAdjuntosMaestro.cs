using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ArchivosAdjuntosMaestro
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public byte[]? Archivo { get; set; }
        public int? IdSysEntidades { get; set; }
        public string? CodigoMaestro { get; set; }
        public string? CodigoMaestro2 { get; set; }
        public string? IdUsuario { get; set; }
        public DateTime FechaGrabacion { get; set; }
        public string? HefestoPathFile { get; set; }
        public string? HefestoPathFileVirtual { get; set; }

        public virtual SysEntidade? IdSysEntidadesNavigation { get; set; }
    }
}
