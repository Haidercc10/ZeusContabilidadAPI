using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AppLogMessage
    {
        public int Id { get; set; }
        public string IdUserFrom { get; set; } = null!;
        public string IdUserTo { get; set; } = null!;
        public string Message { get; set; } = null!;
        public bool IsRead { get; set; }
        public string TypeReceiver { get; set; } = null!;
        public string ListReceiversTo { get; set; } = null!;
        public string PathActiveMq { get; set; } = null!;
        public DateTime ShippingDate { get; set; }
        public DateTime? ReadingDate { get; set; }
        public string? NameUserFrom { get; set; }
    }
}
