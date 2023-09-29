using SplitwiseAbp.FriendShips;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SplitwiseAbp.Friend
{
    public class FriendsAppServices : CrudAppService<Friends, FriendsDto, Guid, PagedAndSortedResultRequestDto, CreateUodateFriendsDto>
    {
        public FriendsAppServices(Volo.Abp.Domain.Repositories.IRepository<Friends, Guid> repository) : base(repository)
        {
        }
    }
}
