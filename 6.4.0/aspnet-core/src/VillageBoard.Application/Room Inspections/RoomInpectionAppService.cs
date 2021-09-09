using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageBoard.Years;

namespace VillageBoard.Room_Inspections
{
    public class RoomInspectionAppService : CrudAppService<Room_Inspection, RoomInspectionDto>
    {
        public RoomInspectionAppService(IRepository<Room_Inspection, int> repository) : base(repository)
        {

        }
    }
}
