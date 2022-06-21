using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Plantilla
    {
        public string FuenteBase { get; set; } = null!;
        public string DocumentoBase { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string? Dfuente { get; set; }
        public string? Dfecha { get; set; }
        public string? Dtercero { get; set; }
        public string? Ddescripcion { get; set; }
        public string? Dcuenta { get; set; }
        public string? Dcentrocosto { get; set; }
        public string? Dauxiliar { get; set; }
        public string? Ditem { get; set; }
        public string? Tcuenta { get; set; }
        public string? Tnit { get; set; }
        public string? Tauxiliar { get; set; }
        public string? Tcentrocosto { get; set; }
        public string? Titem { get; set; }
        public string? Tdescripcion { get; set; }
        public string? Tvalor { get; set; }
        public string? Tbanco { get; set; }
        public string? Tvendedor { get; set; }
        public string? Tplaza { get; set; }
        public string? Ttipofactura { get; set; }
        public string? Tnofactura { get; set; }
        public string? Tvencimiento { get; set; }
        public string? Treferencia { get; set; }
        public string? Tzona { get; set; }
        public string? Tcliprv { get; set; }
        public string? Tbaseimpuesto { get; set; }
        public string? Tdatosimpuesto { get; set; }
        public string? Trubro { get; set; }
        public string? Treserva { get; set; }
        public string? Ttasa { get; set; }
        public string? Tvalormoneda { get; set; }
        public string? Tvrunid1 { get; set; }
        public string? Tvrunid2 { get; set; }
        public string? Tvrunid3 { get; set; }
        public string? Tbeneficiario { get; set; }
        public string? Tserie { get; set; }
        public string? Tautorizacion { get; set; }
        public string? Tfechafact { get; set; }
        public string Tvoucher { get; set; } = null!;
        public string TtasaCambio { get; set; } = null!;
        public string DtasaCambio { get; set; } = null!;
        public string? TfechaCaducidad { get; set; }
        public string? Dserie { get; set; }
        public string Tbu { get; set; } = null!;
        public string Dbu { get; set; } = null!;
        public string? Tpropiedad1 { get; set; }
        public string? Tpropiedad2 { get; set; }
        public string? Tpropiedad3 { get; set; }
        public string? Tpropiedad4 { get; set; }
        public string? Tpropiedad5 { get; set; }
        public string? Tncf { get; set; }
        public int IdenPlantillas { get; set; }
    }
}
