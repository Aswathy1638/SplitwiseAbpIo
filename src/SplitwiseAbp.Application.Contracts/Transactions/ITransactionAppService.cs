using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SplitwiseAbp.Transactions
{
    public interface ITransactionAppService : ICrudAppService<TransactionDto,Guid,PagedAndSortedResultRequestDto,CreateUpdateTransactionDto>
    {
    }
}
