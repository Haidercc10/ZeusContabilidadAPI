using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfEscDatosusuarioadi
    {
        public int IdescDatosusuarioadi { get; set; }
        public int IdescPadre { get; set; }
        public string CodCodeudor { get; set; } = null!;
        public string Barrio { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string Ciudad { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Empresausuario { get; set; } = null!;
        public string Barriousuario { get; set; } = null!;
        public string Direccionusuario { get; set; } = null!;
        public string Ciudadusuario { get; set; } = null!;
        public string Telefonousuario { get; set; } = null!;
        public string Ocupacionusuario { get; set; } = null!;
        public decimal Sueldousuario { get; set; }
        public string Antiguedadusuario { get; set; } = null!;
        public string Conyuge { get; set; } = null!;
        public string Empresaconyuge { get; set; } = null!;
        public string Barrioconyuge { get; set; } = null!;
        public string Direccionconyuge { get; set; } = null!;
        public string Ciudadconyuge { get; set; } = null!;
        public string Telefonoconyuge { get; set; } = null!;
        public string Ocupacionconyuge { get; set; } = null!;
        public decimal Sueldoconyuge { get; set; }
        public string Antiguedadconyuge { get; set; } = null!;
        public string NombreCodeudor { get; set; } = null!;
    }
}
