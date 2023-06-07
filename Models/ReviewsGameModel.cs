using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mvcGames.Models
{
    public class ReviewsGameModel
    {
        [Key]
        public int Id { get; set; }
        [Range(1,5)]
        public int   Stars { get; set; }
        [Required]
        public string? userName { get; set; }
        [Required]
        public string?  Comment { get; set; }

        [ForeignKey("GamesViewModel")]
        public int gameId { get; set; }
        public GamesViewModel GamesViewModel { get; set; }


    }
}