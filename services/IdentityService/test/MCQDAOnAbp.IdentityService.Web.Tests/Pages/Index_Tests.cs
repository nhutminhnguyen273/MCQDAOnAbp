﻿using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace MCQDAOnAbp.IdentityService.Pages;

public class Index_Tests : IdentityServiceWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
