using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfViviendum
    {
        public int IdVivienda { get; set; }
        public int IdPadre { get; set; }
        public string TipoEstudio { get; set; } = null!;
        public string Vivienda { get; set; } = null!;
        public string OtraVivienda { get; set; } = null!;
        public string TipoVivienda { get; set; } = null!;
        public string OtroTipoVivienda { get; set; } = null!;
        public int Npersonas { get; set; }
        public string Csala { get; set; } = null!;
        public string Chabitaciones { get; set; } = null!;
        public string Cpatio { get; set; } = null!;
        public string Cbaños { get; set; } = null!;
        public string Cps { get; set; } = null!;
        public string Nparedes { get; set; } = null!;
        public string Ntecho { get; set; } = null!;
        public string Npuertas { get; set; } = null!;
        public string Nventanas { get; set; } = null!;
        public string Npiso { get; set; } = null!;
        public string Nps { get; set; } = null!;
        public string NservicioSanitario { get; set; } = null!;
        public string Nletrina { get; set; } = null!;
        public string Nalberca { get; set; } = null!;
        public string Nlavadero { get; set; } = null!;
        public string Ncocina { get; set; } = null!;
        public string Titulo { get; set; } = null!;
        public string OtroTitulo { get; set; } = null!;
        public string Observaciones { get; set; } = null!;
    }
}
