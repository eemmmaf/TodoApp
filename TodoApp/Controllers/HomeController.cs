using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Models;

namespace TodoApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //Ändrat sökvägen till "Om-appen"-sidan
        [Route("/omappen")]
        public IActionResult About()
        {
            return View();
        }

        [Route("/attgöra")]
        public IActionResult TodoList()
        {
            //Läser in json och konverterar till IEnumerable
            var jsonStr = System.IO.File.ReadAllText("Todos.json");
            var jsonObj = JsonConvert.DeserializeObject<IEnumerable<Todos>>(jsonStr);

            return View();
        }
    }
}
