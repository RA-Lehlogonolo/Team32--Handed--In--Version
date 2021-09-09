using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Meals
{
    public class MealDto : EntityDto<int>
    {
        [AutoMapFrom(typeof(Meal))]

        [Required]

        [MaxLength(50)]
        public String Name { get; set; }

    }
}
