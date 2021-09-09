using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageBoard.Years;
using Abp.Authorization.Users;
using System.ComponentModel.DataAnnotations.Schema;

namespace VillageBoard.Disciplinary_Hearings
{
   public class Disciplinary_Hearing : Entity<int>
    {
        [Required]
        [MaxLength(150)]
        public string Venue { get; set; }

        [Required]
        [MaxLength(500)]
        public string Decription { get; set; }

        [Required]
        public DateTime Date { get; set; }

        //Fk References
        [ForeignKey(nameof(Year))]
        public int YearId { get; set; }
        public Year Year { get; set; }

        [ForeignKey(nameof(Authorization.Users.User))]
        public long UserId { get; set; }
        public Authorization.Users.User User { get; set; }
    }
}
