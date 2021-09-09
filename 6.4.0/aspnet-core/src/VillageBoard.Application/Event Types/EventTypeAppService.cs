using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Event_Types
{
    public class EventTypeAppService : CrudAppService<Event_Type, EventTypeDto>
    {
        public EventTypeAppService(IRepository<Event_Type, int> repository) : base(repository)
        {

        }

    }
}
