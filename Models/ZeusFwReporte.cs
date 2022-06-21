using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusFwReporte
    {
        public string DsCodigo { get; set; } = null!;
        public string DsTitulo { get; set; } = null!;
        public string? DsNombreArchivo { get; set; }
        public string? DsNombreSp { get; set; }
        public string? DsPath { get; set; }
        public bool? BtSalidaPantalla { get; set; }
        public bool? BtSalidaImpresora { get; set; }
        public bool? BtSalidaArchivo { get; set; }
        public bool? BtSalidaExcel { get; set; }
        public bool? BtSalidaCorreo { get; set; }
        public bool? BtSalidaPdf { get; set; }
        public bool? BtDelSistema { get; set; }
        public bool? BtEspeciales { get; set; }
        public bool? BtReporteBase { get; set; }
        public string? DsDescripcion { get; set; }
        public string? DsXml { get; set; }
        public string? DsXmlAlterno { get; set; }
        public string? DsAplicacion { get; set; }
        public string? DsTipoDocumento { get; set; }
        public int? InOrdenLog { get; set; }
        public int IdenZeusfwReportes { get; set; }
    }
}
