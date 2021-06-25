using ApplicarionService.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.ViewModels
{
    public class ReviewVM
    {
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Comment { get; set; }


        [Required]
        [Range(0, 10)]
        public string Grade { get; set; }

        [Display(Name = "Team")]
        public int TeamID { get; set; }
        public TeamVM TeamVM { get; set; }

        [Display(Name = "Fan")]
        public int FanID { get; set; }
        public FanVM FanVM { get; set; }

        public ReviewVM() { }
        public ReviewVM(ReviewDTO reviewDTO)
        {
            Id = reviewDTO.Id;
            Comment = reviewDTO.Comment;
            Grade = reviewDTO.Grade;

            TeamID = reviewDTO.Team.Id;
            FanID = reviewDTO.Fan.Id;

            TeamVM = new TeamVM
            {
                Id = reviewDTO.Team.Id
            };

            FanVM = new FanVM
            {
                Id = reviewDTO.Fan.Id
            };
        }
    }
}