using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadisonPizzeria.Pages
{
    public class PrivacyModel : PageModel
    {
        //private readonly ILogger<PrivacyModel> _logger;

        //public PrivacyModel(ILogger<PrivacyModel> logger)
        //{
        //  _logger = logger;
        //}
        private readonly IConfiguration _config;
        public string PageTitle { get; set; }
        public PrivacyModel(IConfiguration config)
        {
            _config = config;
        }
        public void OnGet()
        {
            PageTitle = _config["FAQPageTitle"];
        }
    }
}
