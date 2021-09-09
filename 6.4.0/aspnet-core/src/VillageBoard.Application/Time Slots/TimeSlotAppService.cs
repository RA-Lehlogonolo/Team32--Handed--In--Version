using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Time_Slots
{
   public class TimeSlotAppService : CrudAppService<Time_Slot, TimeSlotDto>
    {
        public TimeSlotAppService(IRepository<Time_Slot, int> repository) : base(repository)
        {

        }
    }
}
