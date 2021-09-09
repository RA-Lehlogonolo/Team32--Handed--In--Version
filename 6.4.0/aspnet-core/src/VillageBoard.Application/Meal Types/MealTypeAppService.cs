using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Meal_Types
{
   public class MealTypeAppService : CrudAppService<Meal_Type, MealTypeDto>
    {
        public MealTypeAppService(IRepository<Meal_Type, int> repository) : base(repository)
        {

        }
    }
}
