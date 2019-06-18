using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OloTask.Helpers;
using OloTask.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace OloTask.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (WebClient wc = new WebClient())
            {

                var json = wc.DownloadString("http://files.olo.com/pizzas.json");
                var items = JsonConvert.DeserializeObject<List<ToppingsList>>(json);
                IEnumerable<MostOrderedToppings> mostOrderedCombination = items
                 .Select(i => i.toppings)
                 .GroupBy(s => s, new IEnumerableComparer<string>())
                 .OrderByDescending(g => g.Count())
                 .Select(g => new { Topping = g.Key, Count = g.Count() }).Select((d, i) => new MostOrderedToppings { Topping = d.Topping, Count = d.Count, RowNumber = i + 1 })
                .Take(20);
                return View(mostOrderedCombination);
            }
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
