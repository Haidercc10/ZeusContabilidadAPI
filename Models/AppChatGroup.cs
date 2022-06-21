using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AppChatGroup
    {
        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string IdUserCreator { get; set; } = null!;
        public string Name { get; set; } = null!;
        public bool IsActive { get; set; }
        public DateTime DateCreation { get; set; }
        public string? PathImgGroup { get; set; }
    }
}
