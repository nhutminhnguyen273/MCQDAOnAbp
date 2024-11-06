﻿using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace MCQDAOnAbp.QuestionBankService.Pages;

public class Index_Tests : QuestionBankServiceWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
