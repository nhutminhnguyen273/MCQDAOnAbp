﻿using Xunit;

namespace MCQDAOnAbp.QuestionBankService.EntityFrameworkCore;

[CollectionDefinition(QuestionBankServiceTestConsts.CollectionDefinitionName)]
public class QuestionBankServiceEntityFrameworkCoreCollection : ICollectionFixture<QuestionBankServiceEntityFrameworkCoreFixture>
{

}
