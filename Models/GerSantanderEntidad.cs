﻿using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerSantanderEntidad
    {
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int IdenGersantanderEntidad { get; set; }
    }
}
