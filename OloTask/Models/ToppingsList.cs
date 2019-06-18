using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OloTask.Models
{
    public class ToppingsList
    {
        public string[] toppings { get; set; }
    }
    public class MostOrderedToppings
    {
        public int RowNumber { get; set; }
        public int Count { get; set; }
        public IEnumerable<string> Topping { get; set; }
    }
}