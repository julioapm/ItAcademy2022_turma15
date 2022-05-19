using Microsoft.AspNetCore.Mvc;

namespace DemoWSPizzaria.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    private readonly ILogger<PizzaController> _logger;

    public PizzaController(ILogger<PizzaController> logger)
    {
        _logger = logger;
    }

    [HttpGet()] //.../pizza
    public IEnumerable<Pizza> GetAll()
    {
        return PizzasServices.GetAll();
    }

    [HttpGet("{id}")] //.../pizza/1
    [ProducesResponseType(200)]
    [ProducesResponseType(404)]
    public ActionResult<Pizza> GetById(int id)
    {
        _logger.LogInformation($"Get pizza with id {id}");
        var pizza = PizzasServices.Get(id);
        if (pizza is null) return NotFound();
        return pizza;
    }

    [HttpPut] //.../pizza
    public ActionResult<Pizza> Create(Pizza pizza)
    {
        _logger.LogInformation($"Create pizza:\n {pizza}");
        PizzasServices.Add(pizza);
        return CreatedAtAction(nameof(GetById), new {id=pizza.Id}, pizza);
    }

    [HttpDelete("{id}")] //.../pizza/1
    public IActionResult Delete(int id)
    {
        var pizza = PizzasServices.Get(id);
        if (pizza is null) return NotFound();
        PizzasServices.Delete(id);
        return NoContent();
    }

    [HttpGet("excecao")] //.../pizza/excecao
    public IActionResult GeraExcecao() => throw new Exception("Ocorreu alguma falaha");
}
