namespace DemoEFCoreWebApi.Models;

public class Produto
{
    public int Id {get;set;}
    public string Nome {get;set;} = null!;
    public string? Descricao {get;set;}
    public int PrecoUnitario {get;set;}
}