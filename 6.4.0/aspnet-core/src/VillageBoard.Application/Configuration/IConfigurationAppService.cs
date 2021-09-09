using System.Threading.Tasks;
using VillageBoard.Configuration.Dto;

namespace VillageBoard.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
