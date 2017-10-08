using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GameReviewer.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GameReviewer.Controllers
{
    public class GamesController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(Game.ReadAll());
        }

        [HttpGet] //identifies that this action only gets information
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost] //identifies that this action only pushes information
        public IActionResult Create(Game game)
        {
            Game.Create(game);
            //RedirectToActioin prevents the user from submitting another Create if they hit refresh in the browser
            return RedirectToAction("Index");
        }
    }
}
