using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace ProductSystem.Pages;

public class Index_Tests : ProductSystemWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
