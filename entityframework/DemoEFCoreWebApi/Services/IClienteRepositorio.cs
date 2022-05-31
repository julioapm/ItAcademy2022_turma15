using DemoEFCoreWebApi.Models;
namespace DemoEFCoreWebApi.Services;

public interface IClienteRepositorio
{
    Task<Cliente?> ConsultarAsync(int id);
}