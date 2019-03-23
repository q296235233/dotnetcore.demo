using dotnetcore.core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetcore.core.Entites
{
    public class User
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public Gender Gender { get; set; }

        public string UserName { get; set; }

        public string PassWord { get; set; }
    }
}
