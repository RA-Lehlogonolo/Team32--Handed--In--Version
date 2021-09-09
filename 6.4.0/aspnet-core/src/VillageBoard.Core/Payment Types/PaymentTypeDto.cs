using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Payment_Types
{
   public class PaymentTypeDto : EntityDto<int>
    {
        [AutoMapFrom(typeof(Payment_Type))]

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
