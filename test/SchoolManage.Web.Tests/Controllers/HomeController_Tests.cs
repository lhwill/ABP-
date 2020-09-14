using System.Threading.Tasks;
using SchoolManage.Models.TokenAuth;
using SchoolManage.Web.Controllers;
using Shouldly;
using Xunit;

namespace SchoolManage.Web.Tests.Controllers
{
    public class HomeController_Tests: SchoolManageWebTestBase
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