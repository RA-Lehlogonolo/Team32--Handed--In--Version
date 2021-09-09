using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageBoard.Announcement_Types;
using Abp.Domain.Repositories;

namespace VillageBoard.Annoucement_Types
{
    public class AnnoucementTypeAppService : CrudAppService<Announcement_Type, AnnoucementTypeDto>
    {
        public AnnoucementTypeAppService(IRepository<Announcement_Type, int> repository) : base(repository)
        { 
        }
    }
}
