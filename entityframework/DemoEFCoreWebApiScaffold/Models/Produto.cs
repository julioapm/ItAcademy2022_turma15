using System;
using System.Collections.Generic;

namespace DemoEFCoreWebApiScaffold.Models
{
    public partial class Produto
    {
        public Produto()
        {
            PedidosProdutos = new HashSet<PedidosProduto>();
            CodAutors = new HashSet<Autor>();
        }

        public decimal CodProduto { get; set; }
        public string Titulo { get; set; } = null!;
        public DateTime AnoLancamento { get; set; }
        public string Importado { get; set; } = null!;
        public decimal Preco { get; set; }
        public decimal PrazoEntrega { get; set; }

        public virtual ICollection<PedidosProduto> PedidosProdutos { get; set; }

        public virtual ICollection<Autor> CodAutors { get; set; }
    }
}
