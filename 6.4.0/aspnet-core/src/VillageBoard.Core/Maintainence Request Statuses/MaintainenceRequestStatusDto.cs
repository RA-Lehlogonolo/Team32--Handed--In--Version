using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Maintainence_Request_Statuses
{
    public class MaintainenceRequestStatusDto : EntityDto<int>
    {
        [AutoMapFrom(typeof(Maintainence_Request_Status))]

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
