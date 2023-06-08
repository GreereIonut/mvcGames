using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using mvcGames.Data;
using mvcGames.Models;

namespace mvcGames.Controllers
{


    public class ReviewsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ReviewsController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

            public IActionResult Reviews(int GameId)
            {
                var game = _db.Games.FirstOrDefault(g => g.Id == GameId);
                if (game == null)
                    return NotFound();

                var reviews = _db.Reviews.Where(g => g.gameId == GameId).ToList();
                var viewModel=new ReviewsGameModel{
                    GamesViewModel=game,
                    Reviews=reviews
                    
                };
                if (reviews == null || reviews.Count == 0)
                    return NotFound();

                return View(viewModel);
            }

            public IActionResult InsertReview(){
                return View();
            }

             public IActionResult InsertReviews(ReviewsGameModel review)
        {
            _db.Reviews.Add(review);
            System.Console.WriteLine(review);
            _db.SaveChanges();
            return RedirectToAction("Index","Games");
        }

        



    }
}