using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Menu_Types
{
    public class MenuTypeDto : EntityDto<int>
    {
        [AutoMapFrom(typeof(Menu_Type))]

        [Required]
        public string Name { get; set; }
    }
}
