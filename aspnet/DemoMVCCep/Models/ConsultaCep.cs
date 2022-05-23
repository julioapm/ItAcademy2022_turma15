using System.ComponentModel.DataAnnotations;
namespace DemoMVCCep.Models;

public class ConsultaCep
{
    [Required]
    [StringLength(100)]
    public string Logradouro {get;set;} = null!;
    [Required]
    [StringLength(30)]
    public string Bairro {get;set;} = null!;
    [Required]
    [StringLength(50)]
    public string Cidade {get;set;} = null!;
    [Required]
    [RegularExpression(@"^[A-Z]{2}$")]
    public string Estado {get;set;} = null!;
    [Required]
    [RegularExpression(@"^\d{8}$", ErrorMessage = "O CEP deve conter somente 8 dígitos")]
    public string Cep {get;set;} = null!;
    public override string ToString()
    {
        return $"Logradouro:{Logradouro}, Bairro:{Bairro}, Cidade:{Cidade}, Estado:{Estado}, CEP:{Cep}";
    }
}