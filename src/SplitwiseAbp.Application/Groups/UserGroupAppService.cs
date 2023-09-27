using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace SplitwiseAbp.Groups
{
    public class UserGroupAppService : CrudAppService<UserGroup, UserGroupDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateUserGroupDto>, IUserGroupAppService
    {
        public UserGroupAppService(IRepository<UserGroup, Guid> repository) : base(repository)
        {
        }
    }
}
