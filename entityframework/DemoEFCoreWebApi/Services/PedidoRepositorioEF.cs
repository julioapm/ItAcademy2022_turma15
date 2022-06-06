using DemoEFCoreWebApi.Models;
using Microsoft.EntityFrameworkCore;
namespace DemoEFCoreWebApi.Services;

public class PedidoRepositorioEF : IPedidoRepositorio
{
    private readonly LojinhaContext _contexto;
    public PedidoRepositorioEF(LojinhaContext contexto)
    {
        _contexto = contexto;
    }
    public async Task<Pedido> AdicionarAsync(Pedido pedido)
    {
        await _contexto.Pedidos.AddAsync(pedido);
        await _contexto.SaveChangesAsync();
        return pedido;
    }

    public async Task<Pedido?> ConsultarAsync(int id)
    {
        //Eager loading
        var pedido = await _contexto.Pedidos
                        .Where(p => p.Id == id)
                        .Include(p => p.Cliente)
                        .Include(p => p.Itens)
                        .ThenInclude(i => i.Produto)
                        .FirstOrDefaultAsync();
        
        //Explicit loading
        /*
        var pedido = await _contexto.Pedidos.FindAsync(id);
        if (pedido is not null)
        {
            await _contexto.Entry(pedido).Reference(p => p.Cliente).LoadAsync();
            await _contexto.Entry(pedido).Collection(p => p.Itens).LoadAsync();
            //...
        }
        */
        return pedido;
    }
}