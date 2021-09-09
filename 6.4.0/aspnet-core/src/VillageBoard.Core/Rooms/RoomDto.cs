using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Rooms
{
    public class RoomDto : EntityDto<int>
    {
        [AutoMapFrom(typeof(Room))]

        [Required]
        [MaxLength(50)]
        public string Room_Number { get; set; }
    }
}
