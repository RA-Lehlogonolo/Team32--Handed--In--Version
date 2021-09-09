using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageBoard.Annoucements;

namespace VillageBoard.Announcement_Types
{
   
    public class Announcement_Type : Entity<int>

    {
        [Required]
        [MaxLength(150)]
        public string Description { get; set; }

        public IEnumerable<Announcement> Announcements { get; set; }
    }
}
