using System.Threading.Tasks;
using VillageBoard.Models.TokenAuth;
using VillageBoard.Web.Controllers;
using Shouldly;
using Xunit;

namespace VillageBoard.Web.Tests.Controllers
{
    public class HomeController_Tests: VillageBoardWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}