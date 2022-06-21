using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AppChatGroupsUser
    {
        public int Id { get; set; }
        public int IdChatGroup { get; set; }
        public string IdUser { get; set; } = null!;
    }
}
