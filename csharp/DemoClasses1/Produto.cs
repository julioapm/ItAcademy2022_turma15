public class Produto
{
    public string Id {get;set;}
    public string Descricao {get;set;}
    public decimal ValorUnitario {get;set;}

    public Produto(string umId, string umaDescricao, decimal umValorUnitario)
    {
        Id = umId;
        Descricao = umaDescricao;
        ValorUnitario = umValorUnitario;
    }
}