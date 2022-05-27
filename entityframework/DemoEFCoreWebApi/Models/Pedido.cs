namespace DemoEFCoreWebApi.Models;

public class Pedido
{
    public int Id {get;set;}
    public DateTime DataEmissao {get;set;}
    //relacionamento N:1 com Cliente
    public int ClienteId {get;set;}
    public Cliente Cliente {get;set;} = null!;
    //relacionamento N:N com Produto via Item
    public List<Item> Itens {get;set;} = null!;
    public ICollection<Produto> Produtos {get;set;} = null!;
}