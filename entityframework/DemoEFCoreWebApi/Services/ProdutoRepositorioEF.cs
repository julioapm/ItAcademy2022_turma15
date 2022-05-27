using DemoEFCoreWebApi.Models;
using Microsoft.EntityFrameworkCore;
namespace DemoEFCoreWebApi.Services;

public class ProdutoRepositorioEF : IProdutoRepositorio
{
    private readonly LojinhaContext _contexto;

    public ProdutoRepositorioEF(LojinhaContext contexto)
    {
        _contexto = contexto;
    }

    public async Task<Produto> ConsultarAsync(int id)
    {
        var produto = await _contexto.Produtos.FindAsync(id);
        if (produto is null)
        {
            throw new ProdutoNaoEncontradoException(id);
        }
        return produto;
    }

    public async Task<IEnumerable<Produto>> ConsultarTodosAsync()
    {
        return await _contexto.Produtos.ToListAsync();
    }
}