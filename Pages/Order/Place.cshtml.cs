using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace MadisonPizzeria.Pages.Order
{
    public class PlaceModel : PageModel
    {
        private readonly IConfiguration _config;
        public string PageTitle { get; set; }
        public PlaceModel(IConfiguration config)
        {
            _config = config;
        }
        public void OnGet()
        {
            PageTitle = _config["PlaceOrderPageTitle"];
        }
    }
}
