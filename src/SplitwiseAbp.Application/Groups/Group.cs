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
    public class GroupAppService : CrudAppService<Group, GroupDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateGroupDto>, IGroupAppService
    {
        public GroupAppService(IRepository<Group, Guid> repository) : base(repository)
        {
        }
    }
}
