using Microsoft.AspNetCore.Mvc;

namespace Faculdade.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
