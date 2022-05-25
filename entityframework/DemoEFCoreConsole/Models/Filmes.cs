namespace DemoEFCoreConsole.Models;

public class Filme
{
    public int Id {get; set;}
    public string Titulo {get;set;} = null!;
    public int Ano {get;set;}
    public int? Duracao {get;set;}
    public string? Diretor {get;set;}
    public decimal? DinDin {get;set;}
}