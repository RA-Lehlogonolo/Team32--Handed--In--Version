using Abp.Authorization.Users;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageBoard.Announcement_Types;

namespace VillageBoard.Annoucements
{
    public class Announcement : Entity<int>
    {
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [Required]
        [MaxLength(500)]
        public string Decription { get; set; }

        [Required]
        public DateTime Date { get; set; }

        //FK References 

        [ForeignKey(nameof(Announcement_Type))] 
        public int Announcement_Type_ID { get; set; }
        public Announcement_Type Announcement_Type { get; set; }

        [ForeignKey(nameof(Authorization.Users.User))]
        public long UserId { get; set; }
        public Authorization.Users.User User { get; set; }


    }
}
