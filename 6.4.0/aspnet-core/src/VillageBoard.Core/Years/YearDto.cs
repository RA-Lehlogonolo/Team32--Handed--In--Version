using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Years
{
    public class YearDto : EntityDto<int>
    {
        [AutoMapFrom(typeof(Year))]

        [Required]
        public DateTime Date { get; set; }
    }
}
