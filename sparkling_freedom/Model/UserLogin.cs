using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sparkling_freedom.Model
{
    public class UserLogin
    {
        public long Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public string Usuario { get; set; } = string.Empty;

        public string Senha { get; set; } = string.Empty;

        public string? Foto { get; set; } = string.Empty;

        public string Token { get; set; } = string.Empty;
    }
}