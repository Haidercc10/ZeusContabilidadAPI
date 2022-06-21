using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class PlantillaEmail
    {
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string Asunto { get; set; } = null!;
        public string RutaImagenEncab { get; set; } = null!;
        public string CuerpoEmail { get; set; } = null!;
        public int IndFactura { get; set; }
        public int IndValor { get; set; }
        public int IndVencimiento { get; set; }
        public int IndReferencia { get; set; }
        public int IndFecha { get; set; }
        public int IndDiasVenc { get; set; }
        public string RutaFirmaDigital { get; set; } = null!;
        public string Contacto { get; set; } = null!;
        public string Cargo { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string Ciudad { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public int IdenPlantillaemail { get; set; }
    }
}
