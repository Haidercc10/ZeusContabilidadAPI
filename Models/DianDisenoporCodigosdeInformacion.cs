using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class DianDisenoporCodigosdeInformacion
    {
        public string Ano { get; set; } = null!;
        public string CodigodeInformacion { get; set; } = null!;
        public string TipodeDiseno { get; set; } = null!;
        public int ConsecutivoCampo { get; set; }
        public int PosicionInicial { get; set; }
        public int PosicionFinal { get; set; }
        public string TipodeCampo { get; set; } = null!;
        public int Longitud { get; set; }
        public int Decimales { get; set; }
        public string Contenido { get; set; } = null!;
        public string TipodeVariable { get; set; } = null!;
        public string Idvariable { get; set; } = null!;
        public string? ColumnaExcel { get; set; }
        public string? Etiqueta { get; set; }
        public int IdenDiandisenoporcodigosdeinformacion { get; set; }
    }
}
