using Microsoft.AspNetCore.Mvc;
using DemoEFCoreWebApi.Models;
using DemoEFCoreWebApi.Services;

namespace DemoEFCoreWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CatalogoController : ControllerBase
{
    private readonly ILogger<CatalogoController> _logger;
    private readonly IProdutoRepositorio _produtosRepositorio;

    public CatalogoController(ILogger<CatalogoController> logger, IProdutoRepositorio produtosRepositorio)
    {
        _logger = logger;
        _produtosRepositorio = produtosRepositorio;
    }

    //GET .../catalogo
    [HttpGet]
    public Task<IEnumerable<Produto>> GetTodos()
    {
        return _produtosRepositorio.ConsultarTodosAsync();
    }

    //GET .../catalogo/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<Produto>> GetPorId(int id)
    {
        try
        {
            var produto = await _produtosRepositorio.ConsultarAsync(id);
            return produto;
        }
        catch (ProdutoNaoEncontradoException)
        {
            return NotFound();
        }
    }
}
