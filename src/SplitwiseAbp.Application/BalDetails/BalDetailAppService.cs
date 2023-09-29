using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace SplitwiseAbp.BalDetails
{
    public class BalDetailAppService : CrudAppService<BalDetail, BalDetailDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateBalDetail>
    {
        public BalDetailAppService(IRepository<BalDetail, Guid> repository) : base(repository)
        {
        }
    }
}
