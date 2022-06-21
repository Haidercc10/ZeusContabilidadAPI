using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class VariableEstructuraControl
    {
        public decimal Iden { get; set; }
        public decimal? IdenMaestro { get; set; }
        public decimal? IdenVariable { get; set; }
        public int? Constante { get; set; }
        public string TipoControl { get; set; } = null!;
        public string NombreControl { get; set; } = null!;
        public string Titulo { get; set; } = null!;
        public int X { get; set; }
        public int Y { get; set; }
        public int Ancho { get; set; }
        public int Alto { get; set; }
        public int Xdes { get; set; }
        public int Ydes { get; set; }
        public int AnchoDes { get; set; }
        public int AltoDesc { get; set; }
        public int Xtitulo { get; set; }
        public int Ytitulo { get; set; }
        public int AnchoTitulo { get; set; }
        public int AltoTitulo { get; set; }
        public string FormatoFecha { get; set; } = null!;
        public int Visible { get; set; }
        public string? ToolTipText { get; set; }
        public int Alineacion { get; set; }
        public int Tabs { get; set; }
        public string? TitulosTabs { get; set; }
        public int Orden { get; set; }
        public string? Contenedor { get; set; }
        public int? ContenedorTab { get; set; }
        public int? TabsPerRow { get; set; }
        public int? TabOrientation { get; set; }
        public int? TabDefault { get; set; }
        public int? TabStyle { get; set; }
        public string? TabName0 { get; set; }
        public string? TabName1 { get; set; }
        public string? TabName2 { get; set; }
        public string? TabName3 { get; set; }
        public string? TabName4 { get; set; }
        public string? TabName5 { get; set; }

        public virtual VariableDefinicion? IdenVariableNavigation { get; set; }
    }
}
