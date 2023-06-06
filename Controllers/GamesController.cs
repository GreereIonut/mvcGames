using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvcGames.Models;

namespace mvcGames.Controllers
{
    
    public class GamesController : Controller
    {
        public GamesController()
        {

        }
        private static List<GamesViewModel> games=new List<GamesViewModel>();

        //Dislpay
        public IActionResult Index(){


        return View(games);
       }
        //Create
       public IActionResult Create(){
        var gameVm=new GamesViewModel();

        return View(gameVm);
       }
       public IActionResult CreateGame(GamesViewModel gamesViewModel){
        // return View("Index");
        games.Add(gamesViewModel);
        return RedirectToAction(nameof(Index));
       }

       public string Hello(){
        return "Hello Games Action Controller";
       }
    } 
}