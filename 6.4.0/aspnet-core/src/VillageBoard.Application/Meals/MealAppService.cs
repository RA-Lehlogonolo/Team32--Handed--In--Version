using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Meals
{
    public class MealAppService : CrudAppService<Meal, MealDto>
    {
        public MealAppService(IRepository<Meal, int> repository) : base(repository)
        {

        }
    }
}
