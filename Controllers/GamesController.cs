using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace mvcGames.Controllers
{
    
    public class GamesController : Controller
    {
       public string Index(){
        return "Games Controller";
       }

       public string Hello(){
        return "Hello Games Action Controller";
       }
    } 
}