using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMVCCep.Models;
using DemoMVCCep.Services;

namespace DemoMVCCep.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ICepService _cepservice;

    public HomeController(ILogger<HomeController> logger, ICepService cepService)
    {
        _logger = logger;
        _cepservice = cepService;
    }

    public IActionResult Index()
    {
        var ceps = _cepservice.ConsultaTodos();
        return View(ceps);
    }

    public IActionResult Search(string id)
    {
        ViewData["Id"] = id;
        ConsultaCep? resultado = null;
        if (!String.IsNullOrEmpty(id))
        {
            resultado = _cepservice.ConsultaPorCep(id);
        }
        return View(resultado);
    }

    public IActionResult Create() //GET .../Home/Create
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create([Bind("Cep,Logradouro,Bairro,Cidade,Estado")]ConsultaCep novoCep) //POST .../Home/Create
    {
        if (ModelState.IsValid)
        {
            _cepservice.Cadastrar(novoCep);
            return RedirectToAction(nameof(Index));
        }
        return View(novoCep);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
