using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace MadisonPizzeria.Pages.Order
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration _config;
        public string PageTitle { get; set; }
        public IndexModel(IConfiguration config)
        {
            _config = config;
        }
        public void OnGet()
        {
            PageTitle = _config["PizzaOrderPageTitle"];
        }
    }
}
