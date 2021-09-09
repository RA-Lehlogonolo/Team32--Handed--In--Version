using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageBoard.Blocks;

namespace VillageBoard.Rooms
{
   public  class RoomAppService : CrudAppService<Room, RoomDto>
    {
        public RoomAppService(IRepository<Room, int> repository) : base(repository)
        {
        }
    
    }
}
