using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZiNomIntegraImpArchivo
    {
        public int Spid { get; set; }
        public int CompanyId { get; set; }
        public int AgencyBranchId { get; set; }
        public int DocumentId { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public DateTime Date { get; set; }
        public string Account { get; set; } = null!;
        public string ThirdPartyDocument { get; set; } = null!;
        public int CenterCostId { get; set; }
        public string MovementType { get; set; } = null!;
        public decimal Value { get; set; }
        public decimal Base { get; set; }
        public string Detail { get; set; } = null!;
        public bool Closed { get; set; }
        public int TransactionId { get; set; }
        public string? AnoTra { get; set; }
        public string? FechaTra { get; set; }
        public int IdenZiNomintegraImparchivo { get; set; }
    }
}
