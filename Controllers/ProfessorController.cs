using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace CodingClub.Controllers
{
    public class ProfessorController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Clients()
        {
            return View();
        }
    }
}