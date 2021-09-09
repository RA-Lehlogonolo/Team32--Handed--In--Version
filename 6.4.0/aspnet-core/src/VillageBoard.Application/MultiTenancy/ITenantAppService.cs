using Abp.Application.Services;
using VillageBoard.MultiTenancy.Dto;

namespace VillageBoard.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

