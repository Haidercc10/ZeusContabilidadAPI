using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TipoMaestroEstructuraControl
    {
        public int IdenMaestro { get; set; }
        public string ColNombreFisico { get; set; } = null!;
        public string NombreControl { get; set; } = null!;
        public string TipoControl { get; set; } = null!;
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
        public int Orden { get; set; }
        public int ControlAdicional { get; set; }
        public int IdenTipomaestroEstructuracontrol { get; set; }
    }
}
