using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;

namespace MadisonPizzeria.Models
{
    public class Ingredient
    {
        [BindProperty]
        public string Size { get; set; }

        [BindProperty]
        public string Crust { get; set; }

        [BindProperty]
        public string Sauce { get; set; }

        [BindProperty]
        public string Cheese { get; set; }

        [BindProperty]
        public string Meat { get; set; }

        [BindProperty]
        public string Topping { get; set; }

        [BindProperty]
        public bool Extra { get; set; }

        [BindProperty]
        public float Cost { get; set; }

    }
}
