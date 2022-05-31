﻿using System;
using System.Collections.Generic;

namespace DemoEFCoreWebApiScaffold.Models
{
    public partial class Usuario
    {
        public decimal CodUsuario { get; set; }
        public string Nome { get; set; } = null!;
        public string Cpf { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;

        public virtual Administrador Administradore { get; set; } = null!;
        public virtual Cliente Cliente { get; set; } = null!;
    }
}
