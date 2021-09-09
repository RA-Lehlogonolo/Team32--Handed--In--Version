using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Orders
{
    public class OrderDto : EntityDto<int>
    {
        [AutoMapFrom(typeof(Order))]

        [Required]
        [MaxLength(10)]
        public string Number { get; set; }

        [Required]
        [MaxLength(500)]
        public string Decription { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}
