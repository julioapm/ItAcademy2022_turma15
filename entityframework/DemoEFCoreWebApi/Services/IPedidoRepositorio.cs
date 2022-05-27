using DemoEFCoreWebApi.Models;
namespace DemoEFCoreWebApi.Services;

public interface IPedidoRepositorio
{
    Task<Pedido> AdicionarAsync(Pedido pedido);
}