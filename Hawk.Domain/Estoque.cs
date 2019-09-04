﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hawk.Domain
{
    public class Estoque
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public bool Entrada { get; set; }
        public DateTime DataEntrada { get; set; }

        public Empresa Empresa{ get; set; }
        public int EmpresaId { get; set; }

        public Produto Produto {get; set;}
        public int ProdutoId { get; set; }
    }
}
