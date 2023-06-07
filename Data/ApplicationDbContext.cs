using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mvcGames.Models;

namespace mvcGames.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<GamesViewModel> Games{get; set;}
        public DbSet<ReviewsGameModel> Reviews { get; set; }

    }
}