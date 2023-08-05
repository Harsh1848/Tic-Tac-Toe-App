using Microsoft.AspNetCore.Mvc;
using Tic_Tac_Toe_App.Models;

namespace Tic_Tac_Toe_App.Controllers
{
    public class GameController : Controller
    {
        private readonly GameBoard _gameBoard;

        public GameController()
        {
            _gameBoard = new GameBoard();
        }

        public IActionResult Index()
        {
            return View("~/Views/Home/Index.cshtml", _gameBoard);
        }

        [HttpPost]
        public IActionResult MakeMove(int row, int col)
        {
            if (_gameBoard.MakeMove(row, col))
            {
                // Implement win/draw check here
            }
            return RedirectToAction("Index");
        }
    }
}
