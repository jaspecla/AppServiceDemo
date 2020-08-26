using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace AppServiceDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string LunchSpecial;
        public string Platform;

        public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
        {
            _logger = logger;
            LunchSpecial = configuration.GetValue<string>("LunchSpecial");
            Platform = Environment.OSVersion.VersionString;

        }

        public void OnGet()
        {
            _logger.LogInformation($"Page loaded. Special is {LunchSpecial} and Platform is {Platform}");
        }
    }
}
