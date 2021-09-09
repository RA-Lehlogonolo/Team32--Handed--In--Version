using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Announcement_Types
{
    [AutoMapFrom(typeof(Announcement_Type))]
    public class AnnoucementTypeDto : EntityDto<int>
    {
        [Required]
        [MaxLength(150)]
        public string Description { get; set; }
    }
}
