using DemoEFCoreWebApi.Models;
using Microsoft.EntityFrameworkCore;
namespace DemoEFCoreWebApi.Services;

public class ClienteRepositorioEF : IClienteRepositorio
{
    private readonly LojinhaContext _contexto;
    public ClienteRepositorioEF(LojinhaContext contexto)
    {
        _contexto = contexto;
    }
    public async Task<Cliente?> ConsultarAsync(int id)
    {
        return await _contexto.Clientes.FindAsync(id);
    }
}