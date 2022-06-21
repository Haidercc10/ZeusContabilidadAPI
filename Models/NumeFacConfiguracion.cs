using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class NumeFacConfiguracion
    {
        public string? NumeFacBasedoEn { get; set; }
        public bool QuitarCerosIzquierda { get; set; }
        public bool AñadirPrefijoResolucion { get; set; }
        public string? SeperadorCampos { get; set; }
        public string? SeperadorCamposOtro { get; set; }
        public bool QuitarSerieDcto { get; set; }
        public int IdenNumefacconfiguracion { get; set; }
    }
}
