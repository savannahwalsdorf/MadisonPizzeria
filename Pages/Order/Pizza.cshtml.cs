using MadisonPizzeria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace MadisonPizzeria.Pages.Order
{
    public class PizzaModel : PageModel
    {
        private readonly IConfiguration _config;
        public string PageTitle { get; set; }
        public PizzaModel(IConfiguration config)
        {
            _config = config;
        }
        public void OnGet()
        {
            PageTitle = _config["PizzaOrderPageTitle"];
        }

        public string Ingredients { get; set; }

        public void OnPostSubmit(Ingredient Order) 
        {
            this.Ingredients = string.Format("Order: {0}, {1}", Order.Size, Order.Crust);
        }
    }
}
