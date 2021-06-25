
using Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicarionService.DTOs
{
    public class TeamDTO
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

        public virtual ICollection<Review> Review { get; set; }
    }
}
