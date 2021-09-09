using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageBoard.Annoucements;

namespace VillageBoard.Announcements
{
    public class AnnouncementAppService : CrudAppService<Announcement, AnnouncementDto>
    {
        public AnnouncementAppService(IRepository<Announcement, int> repository) : base(repository)
        {
        }

    }
}
