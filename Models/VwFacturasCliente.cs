using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class VwFacturasCliente
    {
        public long? Idregistro { get; set; }
        public string UnidadNegocio { get; set; } = null!;
        public string Tercero { get; set; } = null!;
        public string NombreTercero { get; set; } = null!;
        public string Cliente { get; set; } = null!;
        public string NombreCliente { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string NombreCuenta { get; set; } = null!;
        public string? AnoVencimiento { get; set; }
        public string? MesVencimiento { get; set; }
        public string TipoFactura { get; set; } = null!;
        public string NombreTipoFactura { get; set; } = null!;
        public string NumeroFactura { get; set; } = null!;
        public string Vendedor { get; set; } = null!;
        public string NombreVendedor { get; set; } = null!;
        public string Zona { get; set; } = null!;
        public string NombreZona { get; set; } = null!;
        public string TipoCliente { get; set; } = null!;
        public string NombreTipoCliente { get; set; } = null!;
        public string? Segmento { get; set; }
        public string NombreSegmento { get; set; } = null!;
        public int? EdadCartera { get; set; }
        public decimal Valor { get; set; }
        public decimal ValorMoneda { get; set; }
        public string? DtFecha { get; set; }
        public int? Anno { get; set; }
        public int? Mes { get; set; }
        public int? Dia { get; set; }
        public string? AnnoMes { get; set; }
        public string? AnnoMesLetra { get; set; }
        public string? FechaLetras { get; set; }
        public int? DiaDeLaSemana { get; set; }
        public string? DiaDelAnno { get; set; }
        public string? NombreDia { get; set; }
        public string? NombreDiaLargo { get; set; }
        public string? NombreDiaCorto { get; set; }
        public int? SemanaDelMes { get; set; }
        public string? SemanaDelAnno { get; set; }
        public string? NombreMes { get; set; }
        public string? NombreMesCorto { get; set; }
        public string? Trimestre { get; set; }
        public string? NombreTrimestre { get; set; }
        public byte? Semestre { get; set; }
        public string? NombreSemestre { get; set; }
        public int FinSemana { get; set; }
        public string? DtFechaVencimiento { get; set; }
        public int? AnnoVencimiento { get; set; }
        public int? MesVencimientoAnalisis { get; set; }
        public int? DiaVencimientoAnalisis { get; set; }
        public string? AnnoMesVencimiento { get; set; }
        public string? AnnoMesLetraVencimiento { get; set; }
        public string? FechaLetrasVencimiento { get; set; }
        public int? DiaDeLaSemanaVencimiento { get; set; }
        public string? DiaDelAnnoVencimiento { get; set; }
        public string? NombreDiaVencimiento { get; set; }
        public string? NombreDiaLargoVencimiento { get; set; }
        public string? NombreDiaCortoVencimiento { get; set; }
        public int? SemanaDelMesVencimiento { get; set; }
        public string? SemanaDelAnnoVencimiento { get; set; }
        public string? NombreMesVencimiento { get; set; }
        public string? NombreMesCortoVencimiento { get; set; }
        public string? TrimestreVencimiento { get; set; }
        public string? NombreTrimestreVencimiento { get; set; }
        public byte? SemestreVencimiento { get; set; }
        public string? NombreSemestreVencimiento { get; set; }
        public int FinSemanaVencimiento { get; set; }
        public string ZolLink { get; set; } = null!;
    }
}
