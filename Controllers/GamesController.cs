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


       public IActionResult Index(){

        GamesViewModel game =new GamesViewModel(){Id=1,Title="Dota2",Description="Best MOBA"};
        return View(game);
       }

       public string Hello(){
        return "Hello Games Action Controller";
       }
    } 
}