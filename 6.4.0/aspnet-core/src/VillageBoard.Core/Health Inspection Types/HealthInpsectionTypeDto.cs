using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Health_Inspection_Types
{
    [AutoMapFrom(typeof(Health_Inpsection_Type))]

    public class HealthInpsectionTypeDto : EntityDto<int>
    {
        [Required]
        [MaxLength(50)]
        public string Description { get; set; }
    }
}
