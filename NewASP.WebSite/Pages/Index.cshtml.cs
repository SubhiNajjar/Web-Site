using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using NewASP.WebSite.Models;
using NewASP.WebSite.Services;

namespace NewASP.WebSite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public JsonFileTrendingService TrendingService;

        public IEnumerable<Trending> Trendings { get; private set; }

        public IndexModel(
            ILogger<IndexModel> logger,
            JsonFileTrendingService trendingService)
        {
            _logger = logger;
            TrendingService = trendingService;
        }

        public void OnGet()
        {
            Trendings = TrendingService.GetTrendings();

        }
    }
}
