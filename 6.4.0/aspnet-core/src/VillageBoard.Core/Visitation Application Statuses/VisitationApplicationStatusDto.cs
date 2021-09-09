using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Visitation_Application_Statuses
{
    public class VisitationApplicationStatusDto : EntityDto<int>
    {
        [AutoMapFrom(typeof(Visitation_Applicaition_Status))]

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Decsription { get; set; }
    }
}
