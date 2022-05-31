namespace DemoEFCoreWebApi.Models;

public class PedidoDTO
{
    public int Id {get;set;}
    public string DataEmissao {get;set;} = null!;
    public string NomeCliente {get;set;} = null!;
    public decimal ValorTotal {get;set;}
    public IEnumerable<ItemDTO> Itens {get;set;} = null!;
    public static PedidoDTO FromPedido(Pedido pedido)
    {
        return new PedidoDTO
        {
            Id = pedido.Id,
            DataEmissao = pedido.DataEmissao.ToShortDateString(),
            NomeCliente = pedido.Cliente.Nome,
            Itens = pedido.Itens.Select(item => ItemDTO.FromItem(item)),
            ValorTotal = pedido.Itens.Sum(item => item.Quantidade * item.Produto.PrecoUnitario)/100M
        };
    }
}

public class ItemDTO
{
    public int IdProduto {get;set;}
    public string NomeProduto {get;set;} = null!;
    public decimal ValorUnitario {get;set;}
    public int Quantidade {get;set;}
    public decimal SubTotal {get;set;}
    public static ItemDTO FromItem(Item item)
    {
        return new ItemDTO
        {
            IdProduto = item.ProdutoId,
            NomeProduto = item.Produto.Nome,
            ValorUnitario = item.Produto.PrecoUnitario/100M,
            Quantidade = item.Quantidade,
            SubTotal = (item.Produto.PrecoUnitario/100M) * item.Quantidade
        };
    }
}