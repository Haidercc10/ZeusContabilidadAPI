using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZiInterfaceDatosTemp
    {
        public string? Aplicacion { get; set; }
        public string? Interface { get; set; }
        public string? Fecha { get; set; }
        public string? Llave1 { get; set; }
        public string? Llave2 { get; set; }
        public string? Llave3 { get; set; }
        public decimal? Orden { get; set; }
        public string? Datos { get; set; }
        public bool? Estado { get; set; }
        public DateTime? FechaGrabacion { get; set; }
        public DateTime? FechaGeneracion { get; set; }
        public decimal Iden { get; set; }
        public int Spid { get; set; }
        public string? Bu { get; set; }
        public string? TextoError { get; set; }
    }
}
