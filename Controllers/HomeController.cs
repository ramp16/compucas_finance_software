using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using compucas_project.Models;
using System.Collections.Generic;

namespace compucas_project.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
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

    //action para mostrar la lista de entidades 
    public IActionResult Index(){
        // Obtiene los datos de tu fuente de datos (por ejemplo, una base de datos)
        List<Entidad> entidades = ObtenerEntidades();

        //Pasa los datos a la vista
        return View(entidades);
    }
    
        // Action para confirmar la eliminación de una entidad
        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            // Elimina la entidad con el ID proporcionado de tu fuente de datos (por ejemplo, una base de datos)

            // Redirige a la acción de índice después de la eliminación exitosa
            return RedirectToAction("Index");
        }

        // Método de ejemplo para obtener una lista de entidades desde tu fuente de


}
