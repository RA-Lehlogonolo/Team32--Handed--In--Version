using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Events
{
   public class EventAppService : CrudAppService<Event, EventDto>
    {
        public EventAppService(IRepository<Event, int> repository) : base(repository)
        {

        }
    }
}
