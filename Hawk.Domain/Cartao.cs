﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hawk.Domain
{
    public class Cartao
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string NomeProprietario { get; set; }
        public DateTime DataVencimento { get; set; }
        public string Cvc { get; set; }
        public bool RegistroAtivo { get; set; }

        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }
    }
}
