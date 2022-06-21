using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfRenovacionCredito
    {
        public int IdRenovacion { get; set; }
        public string TipoEstudio { get; set; } = null!;
        public string Fecha { get; set; } = null!;
        public string? CodUsuario { get; set; }
        public string Direccion { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string CodGrupo { get; set; } = null!;
        public string Lider { get; set; } = null!;
        public string MicroNegociante { get; set; } = null!;
        public string? CodActividad { get; set; }
        public string? CodAsesor { get; set; }
        public decimal VentasCr { get; set; }
        public decimal VentasContado { get; set; }
        public decimal ComprasCr { get; set; }
        public decimal ComprasContado { get; set; }
        public decimal Gastos { get; set; }
        public decimal Caja { get; set; }
        public decimal CxC { get; set; }
        public decimal MateriaPrima { get; set; }
        public decimal ProdProceso { get; set; }
        public decimal ProdElaborado { get; set; }
        public decimal OtrosActivos { get; set; }
        public decimal PcpcxC { get; set; }
        public decimal PlpcxC { get; set; }
        public decimal OtrosPasivos { get; set; }
        public decimal Capital { get; set; }
        public decimal Ingresos { get; set; }
        public decimal OtrosIngresos { get; set; }
        public decimal Arriendo { get; set; }
        public decimal Alimentacion { get; set; }
        public decimal Servicios { get; set; }
        public decimal Transporte { get; set; }
        public decimal Educacion { get; set; }
        public decimal OtrosGastos { get; set; }
        public decimal Excedente { get; set; }
        public decimal Solicitud { get; set; }
        public decimal Inversion { get; set; }
        public decimal Nempleos { get; set; }
        public decimal Npersonas { get; set; }
        public decimal Nrenovaciones { get; set; }
        public string Estado { get; set; } = null!;
        public string TipoCredito { get; set; } = null!;
        public string? CodZona { get; set; }
        public decimal ActivosFijos { get; set; }
        public int IdenMfRenovacioncredito { get; set; }

        public virtual MfActividad? CodActividadNavigation { get; set; }
        public virtual Maevende? CodAsesorNavigation { get; set; }
        public virtual MfDatosusuario? CodUsuarioNavigation { get; set; }
        public virtual Maezona? CodZonaNavigation { get; set; }
    }
}
