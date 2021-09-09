using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageBoard.Rooms;

namespace VillageBoard.Room_Inspections
{
    public class Room_Inspection : Entity<int>
    {
        [Required]
        [MaxLength(10)]
        public string Date { get; set; }

        [Required]
        [MaxLength(10)]
        public string Curtains { get; set; }

        [Required]
        [MaxLength(10)]
        public string Curtain_Rail_Hooks { get; set; }

        [Required]
        [MaxLength(10)]
        public string Globes { get; set; }

        [Required]
        [MaxLength(10)]
        public string Light_Switches { get; set; }

        [Required]
        [MaxLength(10)]
        public string Desk { get; set; }

        [Required]
        [MaxLength(10)]
        public string Chair { get; set; }

        [Required]
        [MaxLength(10)]
        public string Wardrobe_Doors { get; set; }

        [Required]
        [MaxLength(10)]
        public string Mattress { get; set; }

        [Required]
        [MaxLength(10)]
        public string Wall_Sockets { get; set; }

        [Required]
        [MaxLength(10)]
        public string Room_Door { get; set; }

        [Required]
        [MaxLength(10)]
        public string Door_Lock { get; set; }

        [Required]
        [MaxLength(10)]
        public string Mirror { get; set; }

        [Required]
        [MaxLength(10)]
        public string Ceiling { get; set; }

        [Required]
        [MaxLength(10)]
        public string Walls { get; set; }

        [Required]
        [MaxLength(10)]
        public string Floor { get; set; }

        
        [MaxLength(225)]
        public string Other { get; set; }

        //Child Referecnes

        public IEnumerable<Room> Rooms { get; set; }

    }
}
