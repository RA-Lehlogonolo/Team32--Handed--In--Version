using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Room_Statuses
{
    public class RoomStatusDto : EntityDto<int>
    {
        [AutoMapFrom(typeof(Room_Status))]

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
