using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Review : BaseEntity
    {
        [Required]
        [StringLength(150)]
        public string Comment { get; set; }


        [Required]
        [Range(0,10)]
        public string Grade { get; set; }

        public int TeamID { get; set; }
        public virtual Team Team { get; set; }
        public int FanID { get; set; }
        public virtual Fan Fan { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}
