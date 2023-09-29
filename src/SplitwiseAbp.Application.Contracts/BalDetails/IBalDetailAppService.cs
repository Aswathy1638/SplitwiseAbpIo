using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SplitwiseAbp.BalDetails
{
   public interface IBalDetailAppService :ICrudAppService<BalDetailDto,Guid,PagedAndSortedResultRequestDto,CreateUpdateBalDetail>
    {
    }
}
