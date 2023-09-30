using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace SplitwiseAbp.Transactions
{
    public class TransactionAppService : CrudAppService<Transaction, TransactionDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateTransactionDto>
    {
        public TransactionAppService(IRepository<Transaction, Guid> repository) : base(repository)
        {
        }
    }
}
