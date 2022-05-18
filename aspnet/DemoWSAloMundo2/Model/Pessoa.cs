using System.ComponentModel.DataAnnotations;
public class Pessoa
{
    //[Required(AllowEmptyStrings = true)]
    public string Nome {get;set;} = null!;
    [EmailAddress(ErrorMessage = "Deve ser um formato válido de email")]
    public string? Email {get;set;}
    [Range(0,150, ErrorMessage = "Deve estar entre {1} e {2}")]
    public int Idade {get;set;}
}