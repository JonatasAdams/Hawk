﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hawk.Domain.Entities
{
    public class Carrinho
    {
        public int Id { get; set; }

        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }

        public decimal ValorTotal { get; set; }
        public bool RegistroAtivo { get; set; }
        
        public List<ItemCompra> ItensCompra { get; set; }
    }
}
