using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Room_Inspections
{
    public class RoomInspectionDto : EntityDto<int>
    {
        [AutoMapFrom(typeof(RoomInspectionDto))]

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [MaxLength(10)]
        public DateTime Curtains { get; set; }

        [Required]
        [MaxLength(10)]
        public DateTime Curtain_Rail_Hooks { get; set; }

        [Required]
        [MaxLength(10)]
        public DateTime Globes { get; set; }

        [Required]
        [MaxLength(10)]
        public DateTime Light_Switches { get; set; }

        [Required]
        [MaxLength(10)]
        public DateTime Desk { get; set; }

        [Required]
        [MaxLength(10)]
        public DateTime Chair { get; set; }

        [Required]
        [MaxLength(10)]
        public DateTime Wardrobe_Doors { get; set; }

        [Required]
        [MaxLength(10)]
        public DateTime Mattress { get; set; }

        [Required]
        [MaxLength(10)]
        public DateTime Wall_Sockets { get; set; }

        [Required]
        [MaxLength(10)]
        public DateTime Room_Door { get; set; }

        [Required]
        [MaxLength(10)]
        public DateTime Door_Lock { get; set; }

        [Required]
        [MaxLength(10)]
        public DateTime Mirror { get; set; }

        [Required]
        [MaxLength(10)]
        public DateTime Ceiling { get; set; }

        [Required]
        [MaxLength(10)]
        public DateTime Walls { get; set; }

        [Required]
        [MaxLength(10)]
        public DateTime Floor { get; set; }


        [MaxLength(225)]
        public DateTime Other { get; set; }
    }
}
