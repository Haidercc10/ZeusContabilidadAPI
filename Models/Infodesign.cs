using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Infodesign
    {
        public Infodesign()
        {
            ExcelInfodesignperfils = new HashSet<ExcelInfodesignperfil>();
            ExcelInfodesignusuarios = new HashSet<ExcelInfodesignusuario>();
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
        public int IdenInfodesign { get; set; }

        public virtual ICollection<ExcelInfodesignperfil> ExcelInfodesignperfils { get; set; }
        public virtual ICollection<ExcelInfodesignusuario> ExcelInfodesignusuarios { get; set; }
    }
}
