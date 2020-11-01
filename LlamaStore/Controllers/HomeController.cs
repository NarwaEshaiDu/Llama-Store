using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace LlamaStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration configuration;
        private readonly ILogger<HomeController> logger;
        public HomeController(IConfiguration configuration,ILogger<HomeController> logger)
        {
            this.configuration = configuration;
            this.logger = logger;

            logger.LogInformation($"NavBar color: {configuration["NavBar"]}");
            logger.LogInformation($"Store name: {configuration["StoreName"]}");
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BrowserInfo()
        {
            string userAgent = Request.Headers["User-Agent"].ToString();
            ViewBag.UserAgent = userAgent;
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
