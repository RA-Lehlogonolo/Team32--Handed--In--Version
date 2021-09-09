using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Dates
{
    [AutoMapFrom(typeof(Date))]

    public class DateDto : EntityDto<int>
    {
        [Required]
        public DateTime Set_Date { get; set; }
    }
}
