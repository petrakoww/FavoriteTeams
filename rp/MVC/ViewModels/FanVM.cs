using ApplicarionService.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.ViewModels
{
    public class FanVM
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        public byte Age { get; set; }

        public FanVM() { }

        public FanVM(FanDTO fanDTO)
        {
            Id = fanDTO.Id;
            FirstName = fanDTO.FirstName;
            LastName = fanDTO.LastName;
            Age = fanDTO.Age;
        }
    }
}