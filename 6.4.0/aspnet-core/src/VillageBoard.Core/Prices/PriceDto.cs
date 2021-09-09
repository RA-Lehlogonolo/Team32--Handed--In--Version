using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Prices
{
   public  class PriceDto : EntityDto<int>
    {
        [AutoMapFrom(typeof(Price))]

        [Required]
        public decimal ProductPrice { get; set; }


        [Required]
        public DateTime Date { get; set; }
    }
}
