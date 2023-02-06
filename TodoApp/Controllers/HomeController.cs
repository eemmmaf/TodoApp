using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Xml.Linq;
using TodoApp.Models;
using static System.Net.WebRequestMethods;

namespace TodoApp.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            //Läser in json
            var JsonString = System.IO.File.ReadAllText(@"todolist.json");
            //Konverterar till lista av typen Todos
            var JsonObj = JsonConvert.DeserializeObject<List<Todos>>(JsonString);

            return View(JsonObj);
        }

        //Om appen-sida
        [Route("/omappen")]
        public IActionResult About()
        {

            //Viewbags
            ViewBag.AboutAuthor = "Denna app är skapad av mig, Emma Forslund!";
            ViewBag.AboutApp = "Denna app gör det möjligt att hålla koll på vad som ska se framöver. Det går att fylla i namn, beskrivning, datum och prioritet. Det som måste fyllas i är namn, resten är frivilligt.";
            ViewBag.Greeting = "Hoppas att du ska uppskatta denna app och att den kan hjälpa dig att hålla koll på kommande händelser! :)";


            return View();
        }

        [Route("/attgöra")]
        public IActionResult List()
        {

            return View();
        }

        //Metod som lyssnar på Post
        [Route("/attgöra")]
        [HttpPost]
        public IActionResult List(Todos model)
        {

            //Kontroll om formulär är korrekt ifyllt
            if (ModelState.IsValid)
            {
                //Läser in json
                var JsonString = System.IO.File.ReadAllText(@"todolist.json");
                //Konverterar till lista av typen Todos
                var JsonObj = JsonConvert.DeserializeObject<List<Todos>>(JsonString);


                //Om jsonObj inte är null läggs objektet till
                if (JsonObj != null)
                {
                    JsonObj.Add(model);
                    System.IO.File.WriteAllText(@"todolist.json", JsonConvert.SerializeObject(JsonObj, Formatting.Indented));

                    //Redirectar till startsidan där alla items är lagrade
                    return RedirectToAction("Index", "Home");
                };

            }

            return View();
        }

    }
}
