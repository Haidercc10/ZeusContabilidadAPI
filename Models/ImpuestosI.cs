﻿using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ImpuestosI
    {
        public string Anomescta { get; set; } = null!;
        public decimal? Basemvdb { get; set; }
        public decimal? Basemvcr { get; set; }
        public decimal? Valormvdb { get; set; }
        public decimal? Valormvcr { get; set; }
        public decimal Basemvdbmon1 { get; set; }
        public decimal Basemvcrmon1 { get; set; }
        public decimal Valormvdbmon1 { get; set; }
        public decimal Valormvcrmon1 { get; set; }
        public decimal Basemvdbmon2 { get; set; }
        public decimal Basemvcrmon2 { get; set; }
        public decimal Valormvdbmon2 { get; set; }
        public decimal Valormvcrmon2 { get; set; }
        public int IdenImpuestosI { get; set; }
    }
}
