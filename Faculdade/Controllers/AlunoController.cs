using Microsoft.AspNetCore.Mvc;

namespace Faculdade.Controllers
{
    // Controller responsável por gerenciar as requisições relacionadas a Aluno 
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
