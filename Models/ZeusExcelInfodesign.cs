using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusExcelInfodesign
    {
        public ZeusExcelInfodesign()
        {
            ZeusExcelInfodesignPerfils = new HashSet<ZeusExcelInfodesignPerfil>();
            ZeusExcelInfodesignUsuarios = new HashSet<ZeusExcelInfodesignUsuario>();
        }

        public string Idcodigo { get; set; } = null!;
        public string? Descripcion { get; set; }
        public byte[]? Filedesign { get; set; }
        public string? Usuario { get; set; }
        public string? Publico { get; set; }
        public string? Chperfil { get; set; }
        public string? Chusuario { get; set; }
        public string? Perfiles { get; set; }
        public string? Usuarios { get; set; }
        public string? Chmodiusuario { get; set; }
        public string? Chmodiperfil { get; set; }
        public bool? IsPanel { get; set; }
        public byte[]? Imagen { get; set; }
        public int? Orden { get; set; }
        public bool? IsFavorito { get; set; }
        public int Idlibro { get; set; }
        public string? FiledesignOnline { get; set; }
        public string? ImagenOnline { get; set; }
        public bool? IsPanelOnline { get; set; }

        public virtual ICollection<ZeusExcelInfodesignPerfil> ZeusExcelInfodesignPerfils { get; set; }
        public virtual ICollection<ZeusExcelInfodesignUsuario> ZeusExcelInfodesignUsuarios { get; set; }
    }
}
