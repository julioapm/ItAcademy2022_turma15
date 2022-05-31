using System.ComponentModel.DataAnnotations;
namespace DemoEFCoreWebApi.Models;

public class CarrinhoDTO
{
    [Required(ErrorMessage ="IdCliente obrigatório")]
    public int IdCliente {get;set;}
    public IEnumerable<ItemCarrinhoDTO> Itens {get;set;} = null!;
    public override string ToString()
    {
        return $"{IdCliente}\n" + Itens.Count();
    }
}

public class ItemCarrinhoDTO
{
    [Required]
    public int IdProduto {get;set;}
    [Required]
    [Range(1,int.MaxValue)]
    public int Quantidade {get;set;}
    public override string ToString()
    {
        return $"{IdProduto}";
    }
}