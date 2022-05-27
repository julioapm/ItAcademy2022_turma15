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
    public PedidosController(ILogger<PedidosController> logger, IProdutoRepositorio produtosRepositorio)
    {
        _logger = logger;
        _produtosRepositorio = produtosRepositorio;        
    }
}