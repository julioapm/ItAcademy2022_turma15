using DemoMVCCep.Models;
namespace DemoMVCCep.Services;

public interface ICepService
{
    IEnumerable<ConsultaCep> ConsultaTodos();
    ConsultaCep? ConsultaPorCep(string cep);
    void Cadastrar(ConsultaCep cep);
}