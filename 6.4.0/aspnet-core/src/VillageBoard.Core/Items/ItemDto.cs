using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageBoard.Item_Types;

namespace VillageBoard.Items
{
    public class ItemDto : EntityDto<int>
    {
        [AutoMapFrom(typeof(Item))]

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
