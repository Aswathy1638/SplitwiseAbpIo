using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SplitwiseAbp.Groups
{
   public interface IUserGroupAppService : ICrudAppService<UserGroupDto,Guid,PagedAndSortedResultRequestDto,CreateUpdateUserGroupDto>
    {
    }
}
