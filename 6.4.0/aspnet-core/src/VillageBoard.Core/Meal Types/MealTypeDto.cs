using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Meal_Types
{
    public class MealTypeDto : EntityDto<int>
    {
        [AutoMapFrom(typeof(Meal_Type))]

        [Required]
        public string Name { get; set; }
    }
}
