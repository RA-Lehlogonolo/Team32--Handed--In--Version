using Abp.Application.Services;
using Abp.Domain.Repositories;

namespace VillageBoard.Dates
{
    public class DateAppService : CrudAppService<Date, DateDto>
    {
        public DateAppService(IRepository<Date, int> repository) : base(repository)
        {
            
        }

    }
}
