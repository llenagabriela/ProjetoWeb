using Microsoft.AspNetCore.Mvc;
using ProjetoWeb.Models;

namespace ProjetoWeb.Controllers
{
    public class DepartamentsController : Controller
    {
        public IActionResult Index()
        {
            List<Departaments> list = new List<Departaments>();
            list.Add(new Departaments { Id = 1, Name = "Eletronics" });
            list.Add(new Departaments { Id = 2, Name = "Fashion" });

            return View(list);
        }
    }
}
