namespace DemoEFCoreWebApi.Models;

public class Item
{
    public int Quantidade {get;set;}
    //relacionamento N:1 com Produto
    public int ProdutoId {get;set;}
    public Produto Produto {get;set;} = null!;
    //relacionamento N:1 com Pedido
    public int PedidoId {get;set;}
    public Pedido Pedido {get;set;} = null!;
}