using Microsoft.AspNetCore.Mvc;
using DemoEFCoreWebApi.Models;
using DemoEFCoreWebApi.Services;

namespace DemoEFCoreWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PedidosController : ControllerBase
{
    private readonly ILogger<PedidosController> _logger;
    private readonly IProdutoRepositorio _produtosRepositorio;
    private readonly IPedidoRepositorio _pedidosRepositorio;
    private readonly IClienteRepositorio _clientesRepositorio;
    public PedidosController(ILogger<PedidosController> logger,
    IProdutoRepositorio produtosRepositorio, IPedidoRepositorio pedidosRepositorio,
    IClienteRepositorio clientesRepositorio)
    {
        _logger = logger;
        _produtosRepositorio = produtosRepositorio;
        _pedidosRepositorio = pedidosRepositorio;
        _clientesRepositorio = clientesRepositorio;
    }

    //GET .../pedidos/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<PedidoDTO>> GetPedido(int id)
    {
        var pedido = await _pedidosRepositorio.ConsultarAsync(id);
        if (pedido is null)
        {
            return NotFound();
        }
        return PedidoDTO.FromPedido(pedido);
    }

    //GET .../pedidos?cliente={id}

    //POST .../pedidos
    [HttpPost]
    public async Task<ActionResult<PedidoDTO>> PostCarrinho(CarrinhoDTO carrinho)
    {
        _logger.LogInformation(carrinho.ToString());
        //Não convém implementar regras de negócio complexas dentro do controller
        var pedido = new Pedido();
        pedido.DataEmissao = DateTime.Now;
        var cliente = await _clientesRepositorio.ConsultarAsync(carrinho.IdCliente);
        if (cliente is null)
        {
            return BadRequest($"Cliente não encontrado: {carrinho.IdCliente}");
        }
        pedido.Cliente = cliente;
        if (carrinho.Itens.Count() == 0)
        {
            return BadRequest("Carrinho vazio");
        }
        pedido.Itens = new List<Item>();
        foreach (var item in carrinho.Itens)
        {
            try
            {
                var produto = await _produtosRepositorio.ConsultarAsync(item.IdProduto);
                var itemPedido = new Item();
                itemPedido.Produto = produto;
                itemPedido.Quantidade = item.Quantidade;
                pedido.Itens.Add(itemPedido);
            }
            catch(ProdutoNaoEncontradoException)
            {
                return BadRequest($"Produto não encontrado: {item.IdProduto}");
            }
        }
        var novoPedido = await _pedidosRepositorio.AdicionarAsync(pedido);
        return PedidoDTO.FromPedido(novoPedido);
    }
}