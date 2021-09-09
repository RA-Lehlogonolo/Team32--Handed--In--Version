using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Carts
{
    public class CartDto : EntityDto<int>
    {
        [AutoMapFrom(typeof(Cart))]

        [Required]
        public decimal Total { get; set; }
    }
}
