using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MeuProjetoMVC.Models;

namespace MeuProjetoMVC.Controllers;

public class ProdutoController : Controller
{
    public IActionResult Index()
    { 
        ViewBag.Produtos = new List<string>
    {
        "Notebook", "Mouse", "Teclado", "Monitor"
    };
        


        
        ViewBag.Preco = new List<double>{
            2000 ,  200 , 150 ,360

        };

        ViewBag.Total = ((List<double>)ViewBag.Preco).Sum();

        return View();
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