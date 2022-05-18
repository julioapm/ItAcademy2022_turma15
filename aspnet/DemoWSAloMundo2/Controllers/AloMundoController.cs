using Microsoft.AspNetCore.Mvc;

namespace DemoWSAloMundo2.Controllers;

[ApiController]
[Route("/api/v1/[controller]")]
public class AloMundoController : ControllerBase
{
    private readonly ILogger<AloMundoController> _logger;

    public AloMundoController(ILogger<AloMundoController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public string Get()
    {
        _logger.LogInformation("GET /api/v1/alomundo");
        return "Alô, Mundo!";
    }

    [HttpGet("{nome}")]
    public string Get(string nome)
    {
        _logger.LogInformation($"GET /api/v1/alomundo/{nome}");
        return $"Alô, {nome}!";
    }

    [HttpGet("query")] //GET .../api/v1/alomundo/query?nome=John
    public string GetQuery([FromQuery] string nome)
    {
        _logger.LogInformation($"GET /api/v1/alomundo/query?nome={nome}");
        return $"Alô, {nome}!";
    }

    [HttpPost] //POST .../api/v1/alomundo
    public string Post([FromBody] string nome)
    {
        _logger.LogInformation("POST /api/v1/alomundo");
        return $"Alô, {nome}!";
    }

    [HttpPost("pessoa")] //POST .../api/v1/alomundo/pessoa
    public string Post([FromBody] Pessoa pessoa)
    {
        _logger.LogInformation("POST /api/v1/alomundo/pessoa");
        _logger.LogInformation($"Nome={pessoa.Nome}");
        _logger.LogInformation($"Email={pessoa.Email}");
        _logger.LogInformation($"Idade={pessoa.Idade}");
        return $"Alô, {pessoa.Nome}!";
    }
}
