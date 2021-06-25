using ApplicarionService.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.ViewModels
{
    public class TeamVM
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Country { get; set; }
        [Required]
        [Range(1021, 2021)]
        public short Year { get; set; }

        public TeamVM() { }

        public TeamVM(TeamDTO teamDTO)
        {
            Id = teamDTO.Id;
            Name = teamDTO.Name;
            Country = teamDTO.Country;
            Year = teamDTO.Year;
        }
    }
}