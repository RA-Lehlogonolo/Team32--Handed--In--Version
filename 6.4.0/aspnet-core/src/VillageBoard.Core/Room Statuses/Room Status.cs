using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageBoard.Rooms;

namespace VillageBoard.Room_Statuses
{
    public class Room_Status : Entity<int>
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        //Child Referefences

        public IEnumerable<Room> Rooms { get; set; }

    }
}
