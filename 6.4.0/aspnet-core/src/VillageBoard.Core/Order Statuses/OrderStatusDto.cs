using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Order_Statuses
{
    public class OrderStatusDto : EntityDto<int>
    {
        [AutoMapFrom(typeof(Order_Status))]

        [Required]
        [MaxLength(225)]
        public string Description { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
