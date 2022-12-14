using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace MadisonPizzeria.Pages.Cart
{
    public class CartModel : PageModel
    {
        private readonly IConfiguration _config;
        public string PageTitle { get; set; }
        public CartModel(IConfiguration config)
        {
            _config = config;
        }
        public void OnGet()
        {
            PageTitle = _config["CartPageTitle"];
        }
    }
}
