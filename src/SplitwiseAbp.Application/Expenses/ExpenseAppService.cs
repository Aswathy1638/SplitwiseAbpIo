using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace SplitwiseAbp.Expenses
{
    public class ExpenseAppService : CrudAppService<Expense, ExpenseDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateExpenseDto>, IExpenseAppService
    {
        public ExpenseAppService(IRepository<Expense, Guid> repository) : base(repository)
        {
        }
    }
}
