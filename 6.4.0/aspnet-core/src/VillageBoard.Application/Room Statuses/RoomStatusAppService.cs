using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Room_Statuses
{
    public class RoomAppService : CrudAppService<Room_Status, RoomStatusDto>
    {
        public RoomAppService(IRepository<Room_Status, int> repository) : base(repository)
        {

        }
    }
}
