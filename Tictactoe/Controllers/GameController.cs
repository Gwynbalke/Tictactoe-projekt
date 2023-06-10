using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tictactoe.Entities;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tictactoe.Controllers
{
    public class GameController : Controller
    {
        // GET: /<controller>/


        private readonly GameDBcontext _context;

        public GameController(GameDBcontext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var gameList = await _context.Games.ToListAsync();

            return View(gameList);
        }
 
    }
}
