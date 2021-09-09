using System.Threading.Tasks;
using Abp.Application.Services;
using VillageBoard.Sessions.Dto;

namespace VillageBoard.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
