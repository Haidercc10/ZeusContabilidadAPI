using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusExcelPlantillasAcceso
    {
        public int Id { get; set; }
        public int? ZeusExcelPlantillasId { get; set; }
        public string? PerfilNombre { get; set; }
        public string? UsuariosUsuario { get; set; }
        public bool Checked { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string? UsuarioModifico { get; set; }

        public virtual ZeusExcelPlantilla? ZeusExcelPlantillas { get; set; }
    }
}
