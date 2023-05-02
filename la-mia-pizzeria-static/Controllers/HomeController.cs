
// Abbiamo bisogno di creare la nostra prima pagina (index) 
// dove mostriamo tutte le pizze che prepariamo.
// Una pizza avrà le seguenti informazioni :
// - un nome
// - una descrizione
// - una foto
// - un prezzo
// Modifichiamo quindi la view Index.cshtml generata in automatico da .Net Core
// scrivendo l’html che serve a noi per mostrare l’elenco delle pizze
// (possiamo creare una tabella con bootstrap o una qualche grafica a nostro piacimento
// che mostri l’elenco delle pizze...proviamo un po’ di creatività se vogliamo!)
// Piccolo suggerimento : ricordatevi di inserire il seguente codice
// all’inizio della vostra view





using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace la_mia_pizzeria_static.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        // richiesta GET / oppure /home/index
        public IActionResult Index()
        {
            return View();
        }

        // richiesta GET /home/privacy
        public IActionResult Privacy()
        {
            return View();
        }

        // richiesta GET /home/welcome
        public IActionResult Welcome()
        {
            return View();
        }
        // richiesta GET /home/products
        public IActionResult Products()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}