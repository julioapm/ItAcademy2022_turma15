public class Venda
{
    private List<ItemDeVenda> itens = new List<ItemDeVenda>();
    public Pessoa Cliente { get; init; }
    public bool EntregaRealizada { get; set; }

    public void AdicionarItem(Produto umProduto, int umaQuantidade)
    {
        itens.Add(new ItemDeVenda(umProduto,umaQuantidade));
    }

    public void AdicionarItem(Produto umProduto)
    {
        AdicionarItem(umProduto,1);
    }

    public decimal Total
    {
        get
        {
            decimal somatorio = 0;
            foreach(var item in itens)
            {
                somatorio += item.SubTotal;
            }
            return somatorio;
        }
    }

    public int QuantidadeProdutos => itens.Count;

    public Produto this[int i] => itens[i].Produto;

    private class ItemDeVenda
    {
        public Produto Produto {get;set;}
        public int Quantidade {get;set;}
        public ItemDeVenda(Produto umProduto, int umaQuantidade)
        {
            Produto = umProduto;
            Quantidade = umaQuantidade;
        }
        public decimal SubTotal
        {
            get
            {
                return Quantidade * Produto.ValorUnitario;
            }
        }
    }
}