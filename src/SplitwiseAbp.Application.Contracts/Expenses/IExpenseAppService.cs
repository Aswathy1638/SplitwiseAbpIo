﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SplitwiseAbp.Expenses
{
  public interface IExpenseAppService : ICrudAppService<ExpenseDto,Guid,PagedAndSortedResultRequestDto,CreateUpdateExpenseDto>
    {
    }
}
