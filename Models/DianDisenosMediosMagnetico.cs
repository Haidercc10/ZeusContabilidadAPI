using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class DianDisenosMediosMagnetico
    {
        public string Ano { get; set; } = null!;
        public string TipodeDiseno { get; set; } = null!;
        public int ConsecutivoCampo { get; set; }
        public int PosicionInicial { get; set; }
        public int PosicionFinal { get; set; }
        public string TipodeCampo { get; set; } = null!;
        public int Longitud { get; set; }
        public int Decimales { get; set; }
        public string? Contenido { get; set; }
        public string? ColumnaExcel { get; set; }
        public string? Etiqueta { get; set; }
        public int IdenDiandisenosmediosmagneticos { get; set; }
    }
}
