using Microsoft.AspNetCore.Mvc;

namespace Tic_Tac_Toe_App.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
