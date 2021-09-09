using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Products
{
   public class ProductDto : EntityDto<int>
    {
        [AutoMapFrom(typeof(Product))]

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(225)]
        public string Decription { get; set; }

        public byte Image { get; set; }


        [Required]
        public int Qty { get; set; }
    }
}
