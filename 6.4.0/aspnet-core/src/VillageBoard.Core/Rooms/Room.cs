using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageBoard.Blocks;
using VillageBoard.Room_Inspections;
using VillageBoard.Room_Statuses;

namespace VillageBoard.Rooms
{
  public  class Room : Entity<int>
    {
        [Required]
        [MaxLength(50)]
        public string Room_Number { get; set; }

        //FK References

        [ForeignKey(nameof(Block))]
        public int BlockId { get; set; }
        public Block Block { get; set; }

        [ForeignKey(nameof(Room_Inspection))]
        public int RoomInsectionId { get; set; }
        public Room_Inspection Room_Inspection { get; set; }

        [ForeignKey(nameof(Room_Status))]
        public int RoomStatusId { get; set; }
        public Room_Status Room_Status { get; set; }
    }
}
