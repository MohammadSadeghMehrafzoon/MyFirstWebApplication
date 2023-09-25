using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationFirst.Data;
using WebApplicationFirst.Models;

namespace WebApplicationFirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProjectsDetails(int id) {

            var project = ProjectStore.GetProjectBy(id);
            return View(project);
        }

        
        // Contact Action
        
        [HttpGet]
        public IActionResult Contact() 
        { 
            return View(); 
        }

        [HttpPost]
        public JsonResult Contact(IFormCollection form)
        {
            
            return Json(Ok());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}