using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ImpExtractosDefinicionDet
    {
        public long Iden { get; set; }
        public decimal IdenExtractoDefinicion { get; set; }
        public string CodigoCampo { get; set; } = null!;
        public int PosInicial { get; set; }
        public int Longitud { get; set; }
        public int TipoDato { get; set; }
        public int CampoBusqueda { get; set; }
        public int Descripcion { get; set; }
        public int Otro { get; set; }
        public string CampoContable { get; set; } = null!;
        public int Columna { get; set; }

        public virtual ImpExtractosDefinicion IdenExtractoDefinicionNavigation { get; set; } = null!;
    }
}
