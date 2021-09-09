using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Time_Slots
{
    public class TimeSlotDto : EntityDto<int>
    {
        [AutoMapFrom(typeof(Time_Slot))]

        [Required]
        public DateTime Start_Time { get; set; }
        [Required]
        public DateTime End_Time { get; set; }
    }
}
