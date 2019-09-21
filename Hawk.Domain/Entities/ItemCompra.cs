﻿

using System.ComponentModel.DataAnnotations.Schema;

namespace Hawk.Domain.Entities
{
    public class ItemCompra
    {
        public int Id { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal ValorItem { get; set; }
        public bool RegistroAtivo { get; set; }

        public Produto Produto { get; set; }
        public int ProdutoId { get; set; }

        public Compra Compra {get; set; }
        public int CompraId {get; set; }
    }
}
