using DemoEFCoreWebApi.Models;
namespace DemoEFCoreWebApi.Services;

public interface IProdutoRepositorio
{
    Task<IEnumerable<Produto>> ConsultarTodosAsync();
    Task<Produto> ConsultarAsync(int id);
}