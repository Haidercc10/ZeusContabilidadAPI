using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusExcelPlantilla
    {
        public ZeusExcelPlantilla()
        {
            ZeusExcelPlantillasAccesos = new HashSet<ZeusExcelPlantillasAcceso>();
        }

        public int Id { get; set; }
        public int? SqlPlId { get; set; }
        public string? Descripcion { get; set; }
        public string? Aplicacion { get; set; }
        public string? Procedimiento { get; set; }
        public bool IsPublico { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string? UsuarioModifico { get; set; }
        public bool? Activo { get; set; }

        public virtual ICollection<ZeusExcelPlantillasAcceso> ZeusExcelPlantillasAccesos { get; set; }
    }
}
