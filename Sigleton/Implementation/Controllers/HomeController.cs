using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Implementation.Models;
using Implementation.Tools;
using Microsoft.Extensions.Options;
using Implementation.Configuration;

namespace Implementation.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IOptions<Myconfig> _config;
    

    public HomeController(IOptions<Myconfig> config)
    {
        _config = config;
    }

    public IActionResult Index()
    {
        Log.GetInstance(_config.Value.PathLog).Save("Entron a index");
        return View();
    }

    public IActionResult Privacy()
    {
        Log.GetInstance(_config.Value.PathLog).Save("Entron a privacy");
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
