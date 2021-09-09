using System.Threading.Tasks;
using Abp.Application.Services;
using VillageBoard.Authorization.Accounts.Dto;

namespace VillageBoard.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
