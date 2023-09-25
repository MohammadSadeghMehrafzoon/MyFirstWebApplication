using Microsoft.AspNetCore.Mvc;
using WebApplicationFirst.Models;




using WebApplicationFirst.Data;

namespace WebApplicationFirst.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
     

        public IViewComponentResult Invoke()
        {
            var projects = ProjectStore.GetProjects();
            return View("~/Views/Home/Component/Projects/_Projects.cshtml",projects);
        }
    }
}
